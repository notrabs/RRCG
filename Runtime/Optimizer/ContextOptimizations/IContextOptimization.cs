using RRCGBuild;

namespace RRCG.Optimizer.ContextOptimizations
{
    interface IContextOptimization
    {
        /// <summary>
        /// Performs the optimization to the Context and returns the number of optimized nodes.
        /// </summary>
        public int OptimizeContext(Context context);
    }
}
