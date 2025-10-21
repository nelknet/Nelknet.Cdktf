namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type InspectorResourceGroupState<'Tags> = { assignments: ResizeArray<aws.InspectorResourceGroup.InspectorResourceGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_resource_group">aws_inspector_resource_group</a>.
    /// </summary>
    type InspectorResourceGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : InspectorResourceGroupState<Missing> =
            ({ assignments = ResizeArray() } : InspectorResourceGroupState<Missing>)

        member _.Zero(()) : InspectorResourceGroupState<Missing> =
            ({ assignments = ResizeArray() } : InspectorResourceGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_resource_group#tags-1">InspectorResourceGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: InspectorResourceGroupState<Missing>, value: seq<string * string>) : InspectorResourceGroupState<Present> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            ({ assignments = state.assignments } : InspectorResourceGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_resource_group#id-1">InspectorResourceGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: InspectorResourceGroupState<'Tags>, value: string) : InspectorResourceGroupState<'Tags> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : InspectorResourceGroupState<'Tags>

        member _.Run(state: InspectorResourceGroupState<Present>) : aws.InspectorResourceGroup.InspectorResourceGroup =
            let config = aws.InspectorResourceGroup.InspectorResourceGroupConfig()
            for setter in state.assignments do
                setter config
            aws.InspectorResourceGroup.InspectorResourceGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.inspectorResourceGroup: missing required arguments. Must call: tags.", 9999, IsError = true)>]
        member _.Run(_: InspectorResourceGroupState<_>) : aws.InspectorResourceGroup.InspectorResourceGroup =
            Unchecked.defaultof<aws.InspectorResourceGroup.InspectorResourceGroup>
