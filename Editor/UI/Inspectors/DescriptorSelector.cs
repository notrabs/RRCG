using RRCG.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace RRCG
{
    enum DescriptorSelectorPage
    {
        NONE,
        SELECT,
        SELECT_PROJECT,
        SELECT_PROJECT_DESCRIPTOR
    }

    internal class DescriptorSelector
    {
        private DescriptorSelectorPage Page = DescriptorSelectorPage.NONE;
        private Dictionary<string, List<string>> DescriptorOptions = new Dictionary<string, List<string>>();
        private List<string> ProjectDescriptorOptions = new List<string>();
        private string[] ProjectOptions = new string[0];

        private string DisplayName;

        private Func<Dictionary<string, List<string>>> fetchOptions;
        private Func<string, List<string>> fetchOptionsInProject;

        internal DescriptorSelector(string displayName, Func<Dictionary<string, List<string>>> fetchOptions, Func<string, List<string>> fetchOptionsInProject)
        {
            this.DisplayName = displayName;
            this.fetchOptions = fetchOptions;
            this.fetchOptionsInProject = fetchOptionsInProject;
        }

        string ProjectName;

        internal bool Draw(RRCG rrcgMeta)
        {
            switch (Page)
            {
                case DescriptorSelectorPage.SELECT:
                    GUILayout.Label("Available " + DisplayName + "s: ");

                    if (GUILayout.Button("Select from standalone project..."))
                    {
                        GoToProjectsPage();
                    }

                    foreach (var assembly in DescriptorOptions)
                    {
                        GUILayout.Label(assembly.Key);

                        foreach (var className in assembly.Value)
                        {
                            if (GUILayout.Button(className.Replace("RRCGBuild.", "")))
                            {
                                rrcgMeta.Project = null;
                                rrcgMeta.Assembly = assembly.Key;
                                rrcgMeta.DescriptorClass = className;
                                Undo.RecordObject(rrcgMeta, "Configure RRCG " + DisplayName);
                                PrefabUtility.RecordPrefabInstancePropertyModifications(rrcgMeta);
                                EditorUtility.SetDirty(rrcgMeta);
                                Page = DescriptorSelectorPage.NONE;
                            }
                        }
                    }

                    DrawCancelButton();
                    return true;

                case DescriptorSelectorPage.SELECT_PROJECT:

                    GUILayout.Label("Create New Project: ");

                    GUILayout.BeginHorizontal();
                    ProjectName = GUILayout.TextField(ProjectName);
                    if (GUILayout.Button("Create", GUILayout.Width(100)))
                    {
                        if (StandaloneProjectManager.CreateNewProject(ProjectName))  GoToProjectDescriptorPage(ProjectName);
                    }
                    GUILayout.EndHorizontal();

                    GUILayout.Label("Available Projects: ");

                    foreach (var project in ProjectOptions)
                    {
                        if (GUILayout.Button(project)) GoToProjectDescriptorPage(project);
                    }

                    DrawCancelButton();
                    return true;

                case DescriptorSelectorPage.SELECT_PROJECT_DESCRIPTOR:

                    foreach (var descriptor in ProjectDescriptorOptions)
                    {
                        if (GUILayout.Button(descriptor))
                        {
                            rrcgMeta.Project = null;
                            rrcgMeta.Assembly = null;
                            rrcgMeta.DescriptorClass = descriptor;
                            Undo.RecordObject(rrcgMeta, "Configure RRCG " + DisplayName);
                            PrefabUtility.RecordPrefabInstancePropertyModifications(rrcgMeta);
                            EditorUtility.SetDirty(rrcgMeta);

                            Page = DescriptorSelectorPage.NONE;
                        }
                    }

                    DrawCancelButton();
                    return true;
            }

            GUILayout.Label(DisplayName);
            GUILayout.BeginHorizontal();
            if (rrcgMeta.DescriptorClass != null)
            {
                GUILayout.Label(rrcgMeta.DescriptorClass);
            }
            if (GUILayout.Button("Select..."))
            {
                DescriptorOptions = fetchOptions();
                Page = DescriptorSelectorPage.SELECT;
            }
            GUILayout.EndHorizontal();

            return false;
        }

        void GoToProjectsPage()
        {
            ProjectName = "";
            ProjectOptions = StandaloneProjectManager.GetProjects().ToArray();
            Page = DescriptorSelectorPage.SELECT_PROJECT;
        }

        void GoToProjectDescriptorPage(string projectName)
        {
            ProjectName = projectName;
            ProjectDescriptorOptions = fetchOptionsInProject(projectName);
            Page = DescriptorSelectorPage.SELECT_PROJECT_DESCRIPTOR;
        }

        void DrawCancelButton()
        {
            GUILayout.Space(10);
            if (GUILayout.Button("Cancel"))
            {
                Page = DescriptorSelectorPage.NONE;
            }
        }
    }
}
