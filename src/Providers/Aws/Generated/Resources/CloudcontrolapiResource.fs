namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudcontrolapiResourceState<'DesiredState, 'TypeName> = { assignments: ResizeArray<aws.CloudcontrolapiResource.CloudcontrolapiResourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudcontrolapi_resource">aws_cloudcontrolapi_resource</a>.
    /// </summary>
    type CloudcontrolapiResourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudcontrolapiResourceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudcontrolapiResourceState<Missing, Missing>)

        member _.Zero(()) : CloudcontrolapiResourceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudcontrolapiResourceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudcontrolapi_resource#desired_state-1">CloudcontrolapiResource#desired_state</a>.
        /// </summary>
        [<CustomOperation "desired_state">]
        member _.DesiredState(state: CloudcontrolapiResourceState<Missing, 'TypeName>, value: string) : CloudcontrolapiResourceState<Present, 'TypeName> =
            state.assignments.Add(fun config -> config.DesiredState <- value)
            ({ assignments = state.assignments } : CloudcontrolapiResourceState<Present, 'TypeName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudcontrolapi_resource#type_name-1">CloudcontrolapiResource#type_name</a>.
        /// </summary>
        [<CustomOperation "type_name">]
        member _.TypeName(state: CloudcontrolapiResourceState<'DesiredState, Missing>, value: string) : CloudcontrolapiResourceState<'DesiredState, Present> =
            state.assignments.Add(fun config -> config.TypeName <- value)
            ({ assignments = state.assignments } : CloudcontrolapiResourceState<'DesiredState, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudcontrolapi_resource#id-1">CloudcontrolapiResource#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudcontrolapiResourceState<'DesiredState, 'TypeName>, value: string) : CloudcontrolapiResourceState<'DesiredState, 'TypeName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudcontrolapiResourceState<'DesiredState, 'TypeName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudcontrolapi_resource#role_arn-1">CloudcontrolapiResource#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: CloudcontrolapiResourceState<'DesiredState, 'TypeName>, value: string) : CloudcontrolapiResourceState<'DesiredState, 'TypeName> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            state : CloudcontrolapiResourceState<'DesiredState, 'TypeName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudcontrolapi_resource#schema-1">CloudcontrolapiResource#schema</a>.
        /// </summary>
        [<CustomOperation "schema">]
        member _.Schema(state: CloudcontrolapiResourceState<'DesiredState, 'TypeName>, value: string) : CloudcontrolapiResourceState<'DesiredState, 'TypeName> =
            state.assignments.Add(fun config -> config.Schema <- value)
            state : CloudcontrolapiResourceState<'DesiredState, 'TypeName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudcontrolapi_resource#timeouts-1">CloudcontrolapiResource#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CloudcontrolapiResourceState<'DesiredState, 'TypeName>, value: aws.CloudcontrolapiResource.CloudcontrolapiResourceTimeouts) : CloudcontrolapiResourceState<'DesiredState, 'TypeName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CloudcontrolapiResourceState<'DesiredState, 'TypeName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudcontrolapi_resource#type_version_id-1">CloudcontrolapiResource#type_version_id</a>.
        /// </summary>
        [<CustomOperation "type_version_id">]
        member _.TypeVersionId(state: CloudcontrolapiResourceState<'DesiredState, 'TypeName>, value: string) : CloudcontrolapiResourceState<'DesiredState, 'TypeName> =
            state.assignments.Add(fun config -> config.TypeVersionId <- value)
            state : CloudcontrolapiResourceState<'DesiredState, 'TypeName>

        member _.Run(state: CloudcontrolapiResourceState<Present, Present>) : aws.CloudcontrolapiResource.CloudcontrolapiResource =
            let config = aws.CloudcontrolapiResource.CloudcontrolapiResourceConfig()
            for setter in state.assignments do
                setter config
            aws.CloudcontrolapiResource.CloudcontrolapiResource(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudcontrolapiResource: missing required arguments. Must call: desired_state, type_name.", 9999, IsError = true)>]
        member _.Run(_: CloudcontrolapiResourceState<_, _>) : aws.CloudcontrolapiResource.CloudcontrolapiResource =
            Unchecked.defaultof<aws.CloudcontrolapiResource.CloudcontrolapiResource>
