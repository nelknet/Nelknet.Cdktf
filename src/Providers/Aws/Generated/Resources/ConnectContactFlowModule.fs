namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConnectContactFlowModuleState<'InstanceId, 'Name> = { assignments: ResizeArray<aws.ConnectContactFlowModule.ConnectContactFlowModuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_contact_flow_module">aws_connect_contact_flow_module</a>.
    /// </summary>
    type ConnectContactFlowModuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConnectContactFlowModuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectContactFlowModuleState<Missing, Missing>)

        member _.Zero(()) : ConnectContactFlowModuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectContactFlowModuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_contact_flow_module#instance_id-1">ConnectContactFlowModule#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: ConnectContactFlowModuleState<Missing, 'Name>, value: string) : ConnectContactFlowModuleState<Present, 'Name> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : ConnectContactFlowModuleState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_contact_flow_module#name-1">ConnectContactFlowModule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConnectContactFlowModuleState<'InstanceId, Missing>, value: string) : ConnectContactFlowModuleState<'InstanceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ConnectContactFlowModuleState<'InstanceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_contact_flow_module#content-1">ConnectContactFlowModule#content</a>.
        /// </summary>
        [<CustomOperation "content">]
        member _.Content(state: ConnectContactFlowModuleState<'InstanceId, 'Name>, value: string) : ConnectContactFlowModuleState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Content <- value)
            state : ConnectContactFlowModuleState<'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_contact_flow_module#content_hash-1">ConnectContactFlowModule#content_hash</a>.
        /// </summary>
        [<CustomOperation "content_hash">]
        member _.ContentHash(state: ConnectContactFlowModuleState<'InstanceId, 'Name>, value: string) : ConnectContactFlowModuleState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.ContentHash <- value)
            state : ConnectContactFlowModuleState<'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_contact_flow_module#description-1">ConnectContactFlowModule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ConnectContactFlowModuleState<'InstanceId, 'Name>, value: string) : ConnectContactFlowModuleState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ConnectContactFlowModuleState<'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_contact_flow_module#filename-1">ConnectContactFlowModule#filename</a>.
        /// </summary>
        [<CustomOperation "filename">]
        member _.Filename(state: ConnectContactFlowModuleState<'InstanceId, 'Name>, value: string) : ConnectContactFlowModuleState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Filename <- value)
            state : ConnectContactFlowModuleState<'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_contact_flow_module#id-1">ConnectContactFlowModule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConnectContactFlowModuleState<'InstanceId, 'Name>, value: string) : ConnectContactFlowModuleState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConnectContactFlowModuleState<'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_contact_flow_module#tags-1">ConnectContactFlowModule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ConnectContactFlowModuleState<'InstanceId, 'Name>, value: seq<string * string>) : ConnectContactFlowModuleState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ConnectContactFlowModuleState<'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_contact_flow_module#tags_all-1">ConnectContactFlowModule#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ConnectContactFlowModuleState<'InstanceId, 'Name>, value: seq<string * string>) : ConnectContactFlowModuleState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ConnectContactFlowModuleState<'InstanceId, 'Name>

        member _.Run(state: ConnectContactFlowModuleState<Present, Present>) : aws.ConnectContactFlowModule.ConnectContactFlowModule =
            let config = aws.ConnectContactFlowModule.ConnectContactFlowModuleConfig()
            for setter in state.assignments do
                setter config
            aws.ConnectContactFlowModule.ConnectContactFlowModule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.connectContactFlowModule: missing required arguments. Must call: instance_id, name.", 9999, IsError = true)>]
        member _.Run(_: ConnectContactFlowModuleState<_, _>) : aws.ConnectContactFlowModule.ConnectContactFlowModule =
            Unchecked.defaultof<aws.ConnectContactFlowModule.ConnectContactFlowModule>
