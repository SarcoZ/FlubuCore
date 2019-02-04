
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerDeployTask : ExternalProcessTaskBase<int, DockerDeployTask>
     {
        private string _stack;

        
        public DockerDeployTask(string stack)
        {
            ExecutablePath = "docker";
            WithArguments("deploy");
_stack = stack;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Path to a Distributed Application Bundle file
        /// </summary>
        public DockerDeployTask BundleFile(string bundleFile)
        {
            WithArgumentsValueRequired("bundle-file", bundleFile.ToString());
            return this;
        }

        /// <summary>
        /// Path to a Compose file
        /// </summary>
        public DockerDeployTask ComposeFile(string composeFile)
        {
            WithArgumentsValueRequired("compose-file", composeFile.ToString());
            return this;
        }

        /// <summary>
        /// Prune services that are no longer referenced
        /// </summary>
        public DockerDeployTask Prune()
        {
            WithArguments("prune");
            return this;
        }

        /// <summary>
        /// Query the registry to resolve image digest and supported platforms ("always"|"changed"|"never")

        /// </summary>
        public DockerDeployTask ResolveImage(string resolveImage)
        {
            WithArgumentsValueRequired("resolve-image", resolveImage.ToString());
            return this;
        }

        /// <summary>
        /// Send registry authentication details to Swarm agents
        /// </summary>
        public DockerDeployTask WithRegistryAuth()
        {
            WithArguments("with-registry-auth");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_stack);

            return base.DoExecute(context);
        }

     }
}
