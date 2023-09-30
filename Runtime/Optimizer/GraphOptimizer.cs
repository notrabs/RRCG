using RRCGBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRCG.Optimizer
{
    public class GraphOptimizer
    {

        public static Context Optimize(Context context)
        {
            foreach (var node in context.Nodes)
            {
                //if (node.Type == )
            }


            context.SubContexts = context.SubContexts.Select(Optimize).ToList();

            return context;
        }

    }
}
