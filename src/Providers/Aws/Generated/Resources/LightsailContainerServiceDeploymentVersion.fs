namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailContainerServiceDeploymentVersionState<'Container, 'ServiceName> = { assignments: ResizeArray<aws.LightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service_deployment_version">aws_lightsail_container_service_deployment_version</a>.
    /// </summary>
    type LightsailContainerServiceDeploymentVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailContainerServiceDeploymentVersionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailContainerServiceDeploymentVersionState<Missing, Missing>)

        member _.Zero(()) : LightsailContainerServiceDeploymentVersionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailContainerServiceDeploymentVersionState<Missing, Missing>)

        /// <summary>
        /// container block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service_deployment_version#container-1">LightsailContainerServiceDeploymentVersion#container</a> Accepts: aws.IResolvable | aws.LightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionContainer[]
        /// </summary>
        [<CustomOperation "container">]
        member _.Container(state: LightsailContainerServiceDeploymentVersionState<Missing, 'ServiceName>, value: HashiCorp.Cdktf.IResolvable) : LightsailContainerServiceDeploymentVersionState<Present, 'ServiceName> =
            state.assignments.Add(fun config -> config.Container <- value)
            ({ assignments = state.assignments } : LightsailContainerServiceDeploymentVersionState<Present, 'ServiceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service_deployment_version#service_name-1">LightsailContainerServiceDeploymentVersion#service_name</a>.
        /// </summary>
        [<CustomOperation "service_name">]
        member _.ServiceName(state: LightsailContainerServiceDeploymentVersionState<'Container, Missing>, value: string) : LightsailContainerServiceDeploymentVersionState<'Container, Present> =
            state.assignments.Add(fun config -> config.ServiceName <- value)
            ({ assignments = state.assignments } : LightsailContainerServiceDeploymentVersionState<'Container, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service_deployment_version#id-1">LightsailContainerServiceDeploymentVersion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailContainerServiceDeploymentVersionState<'Container, 'ServiceName>, value: string) : LightsailContainerServiceDeploymentVersionState<'Container, 'ServiceName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailContainerServiceDeploymentVersionState<'Container, 'ServiceName>

        /// <summary>
        /// public_endpoint block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service_deployment_version#public_endpoint-1">LightsailContainerServiceDeploymentVersion#public_endpoint</a>
        /// </summary>
        [<CustomOperation "public_endpoint">]
        member _.PublicEndpoint(state: LightsailContainerServiceDeploymentVersionState<'Container, 'ServiceName>, value: aws.LightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionPublicEndpoint) : LightsailContainerServiceDeploymentVersionState<'Container, 'ServiceName> =
            state.assignments.Add(fun config -> config.PublicEndpoint <- value)
            state : LightsailContainerServiceDeploymentVersionState<'Container, 'ServiceName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service_deployment_version#timeouts-1">LightsailContainerServiceDeploymentVersion#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LightsailContainerServiceDeploymentVersionState<'Container, 'ServiceName>, value: aws.LightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionTimeouts) : LightsailContainerServiceDeploymentVersionState<'Container, 'ServiceName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LightsailContainerServiceDeploymentVersionState<'Container, 'ServiceName>

        member _.Run(state: LightsailContainerServiceDeploymentVersionState<Present, Present>) : aws.LightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersion =
            let config = aws.LightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailContainerServiceDeploymentVersion: missing required arguments. Must call: container, service_name.", 9999, IsError = true)>]
        member _.Run(_: LightsailContainerServiceDeploymentVersionState<_, _>) : aws.LightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersion =
            Unchecked.defaultof<aws.LightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersion>
