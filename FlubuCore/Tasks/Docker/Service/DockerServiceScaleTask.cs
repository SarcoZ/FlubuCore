
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Service
{
     public partial class DockerServiceScaleTask : ExternalProcessTaskBase<int, DockerServiceScaleTask>
     {
        
        
        public DockerServiceScaleTask()
        {
            ExecutablePath = "docker";
            WithArguments("service scale");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Exit immediately instead of waiting for the service to converge

        /// </summary>
        public DockerServiceScaleTask Detach()
        {
            WithArguments("detach");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
            
            return base.DoExecute(context);
        }

     }
}
