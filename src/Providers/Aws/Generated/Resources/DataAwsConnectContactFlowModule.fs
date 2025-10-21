namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsConnectContactFlowModuleState<'InstanceId> = { assignments: ResizeArray<aws.DataAwsConnectContactFlowModule.DataAwsConnectContactFlowModuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_contact_flow_module">aws_connect_contact_flow_module</a>.
    /// </summary>
    type DataAwsConnectContactFlowModuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsConnectContactFlowModuleState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectContactFlowModuleState<Missing>)

        member _.Zero(()) : DataAwsConnectContactFlowModuleState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectContactFlowModuleState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_contact_flow_module#instance_id-1">DataAwsConnectContactFlowModule#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: DataAwsConnectContactFlowModuleState<Missing>, value: string) : DataAwsConnectContactFlowModuleState<Present> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : DataAwsConnectContactFlowModuleState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_contact_flow_module#contact_flow_module_id-1">DataAwsConnectContactFlowModule#contact_flow_module_id</a>.
        /// </summary>
        [<CustomOperation "contact_flow_module_id">]
        member _.ContactFlowModuleId(state: DataAwsConnectContactFlowModuleState<'InstanceId>, value: string) : DataAwsConnectContactFlowModuleState<'InstanceId> =
            state.assignments.Add(fun config -> config.ContactFlowModuleId <- value)
            state : DataAwsConnectContactFlowModuleState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_contact_flow_module#id-1">DataAwsConnectContactFlowModule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsConnectContactFlowModuleState<'InstanceId>, value: string) : DataAwsConnectContactFlowModuleState<'InstanceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsConnectContactFlowModuleState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_contact_flow_module#name-1">DataAwsConnectContactFlowModule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsConnectContactFlowModuleState<'InstanceId>, value: string) : DataAwsConnectContactFlowModuleState<'InstanceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsConnectContactFlowModuleState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_contact_flow_module#tags-1">DataAwsConnectContactFlowModule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsConnectContactFlowModuleState<'InstanceId>, value: seq<string * string>) : DataAwsConnectContactFlowModuleState<'InstanceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsConnectContactFlowModuleState<'InstanceId>

        member _.Run(state: DataAwsConnectContactFlowModuleState<Present>) : aws.DataAwsConnectContactFlowModule.DataAwsConnectContactFlowModule =
            let config = aws.DataAwsConnectContactFlowModule.DataAwsConnectContactFlowModuleConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsConnectContactFlowModule.DataAwsConnectContactFlowModule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsConnectContactFlowModule: missing required arguments. Must call: instance_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsConnectContactFlowModuleState<_>) : aws.DataAwsConnectContactFlowModule.DataAwsConnectContactFlowModule =
            Unchecked.defaultof<aws.DataAwsConnectContactFlowModule.DataAwsConnectContactFlowModule>
