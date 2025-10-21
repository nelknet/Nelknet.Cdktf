namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsConnectContactFlowState<'InstanceId> = { assignments: ResizeArray<aws.DataAwsConnectContactFlow.DataAwsConnectContactFlowConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_contact_flow">aws_connect_contact_flow</a>.
    /// </summary>
    type DataAwsConnectContactFlowBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsConnectContactFlowState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectContactFlowState<Missing>)

        member _.Zero(()) : DataAwsConnectContactFlowState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectContactFlowState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_contact_flow#instance_id-1">DataAwsConnectContactFlow#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: DataAwsConnectContactFlowState<Missing>, value: string) : DataAwsConnectContactFlowState<Present> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : DataAwsConnectContactFlowState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_contact_flow#contact_flow_id-1">DataAwsConnectContactFlow#contact_flow_id</a>.
        /// </summary>
        [<CustomOperation "contact_flow_id">]
        member _.ContactFlowId(state: DataAwsConnectContactFlowState<'InstanceId>, value: string) : DataAwsConnectContactFlowState<'InstanceId> =
            state.assignments.Add(fun config -> config.ContactFlowId <- value)
            state : DataAwsConnectContactFlowState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_contact_flow#id-1">DataAwsConnectContactFlow#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsConnectContactFlowState<'InstanceId>, value: string) : DataAwsConnectContactFlowState<'InstanceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsConnectContactFlowState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_contact_flow#name-1">DataAwsConnectContactFlow#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsConnectContactFlowState<'InstanceId>, value: string) : DataAwsConnectContactFlowState<'InstanceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsConnectContactFlowState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_contact_flow#tags-1">DataAwsConnectContactFlow#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsConnectContactFlowState<'InstanceId>, value: seq<string * string>) : DataAwsConnectContactFlowState<'InstanceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsConnectContactFlowState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_contact_flow#type-1">DataAwsConnectContactFlow#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: DataAwsConnectContactFlowState<'InstanceId>, value: string) : DataAwsConnectContactFlowState<'InstanceId> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : DataAwsConnectContactFlowState<'InstanceId>

        member _.Run(state: DataAwsConnectContactFlowState<Present>) : aws.DataAwsConnectContactFlow.DataAwsConnectContactFlow =
            let config = aws.DataAwsConnectContactFlow.DataAwsConnectContactFlowConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsConnectContactFlow.DataAwsConnectContactFlow(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsConnectContactFlow: missing required arguments. Must call: instance_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsConnectContactFlowState<_>) : aws.DataAwsConnectContactFlow.DataAwsConnectContactFlow =
            Unchecked.defaultof<aws.DataAwsConnectContactFlow.DataAwsConnectContactFlow>
