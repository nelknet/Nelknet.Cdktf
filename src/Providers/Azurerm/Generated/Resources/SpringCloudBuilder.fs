namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudBuilderState<'BuildPackGroup, 'Name, 'SpringCloudServiceId, 'Stack> = { assignments: ResizeArray<azurerm.SpringCloudBuilder.SpringCloudBuilderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_builder">azurerm_spring_cloud_builder</a>.
    /// </summary>
    type SpringCloudBuilderBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudBuilderState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudBuilderState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SpringCloudBuilderState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudBuilderState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// build_pack_group block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_builder#build_pack_group-1">SpringCloudBuilder#build_pack_group</a> Accepts: azurerm.IResolvable | azurerm.SpringCloudBuilder.SpringCloudBuilderBuildPackGroup[]
        /// </summary>
        [<CustomOperation "build_pack_group">]
        member _.BuildPackGroup(state: SpringCloudBuilderState<Missing, 'Name, 'SpringCloudServiceId, 'Stack>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudBuilderState<Present, 'Name, 'SpringCloudServiceId, 'Stack> =
            state.assignments.Add(fun config -> config.BuildPackGroup <- value)
            ({ assignments = state.assignments } : SpringCloudBuilderState<Present, 'Name, 'SpringCloudServiceId, 'Stack>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_builder#name-1">SpringCloudBuilder#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudBuilderState<'BuildPackGroup, Missing, 'SpringCloudServiceId, 'Stack>, value: string) : SpringCloudBuilderState<'BuildPackGroup, Present, 'SpringCloudServiceId, 'Stack> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudBuilderState<'BuildPackGroup, Present, 'SpringCloudServiceId, 'Stack>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_builder#spring_cloud_service_id-1">SpringCloudBuilder#spring_cloud_service_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_service_id">]
        member _.SpringCloudServiceId(state: SpringCloudBuilderState<'BuildPackGroup, 'Name, Missing, 'Stack>, value: string) : SpringCloudBuilderState<'BuildPackGroup, 'Name, Present, 'Stack> =
            state.assignments.Add(fun config -> config.SpringCloudServiceId <- value)
            ({ assignments = state.assignments } : SpringCloudBuilderState<'BuildPackGroup, 'Name, Present, 'Stack>)

        /// <summary>
        /// stack block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_builder#stack-1">SpringCloudBuilder#stack</a>
        /// </summary>
        [<CustomOperation "stack">]
        member _.Stack(state: SpringCloudBuilderState<'BuildPackGroup, 'Name, 'SpringCloudServiceId, Missing>, value: azurerm.SpringCloudBuilder.SpringCloudBuilderStack) : SpringCloudBuilderState<'BuildPackGroup, 'Name, 'SpringCloudServiceId, Present> =
            state.assignments.Add(fun config -> config.Stack <- value)
            ({ assignments = state.assignments } : SpringCloudBuilderState<'BuildPackGroup, 'Name, 'SpringCloudServiceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_builder#id-1">SpringCloudBuilder#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudBuilderState<'BuildPackGroup, 'Name, 'SpringCloudServiceId, 'Stack>, value: string) : SpringCloudBuilderState<'BuildPackGroup, 'Name, 'SpringCloudServiceId, 'Stack> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudBuilderState<'BuildPackGroup, 'Name, 'SpringCloudServiceId, 'Stack>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_builder#timeouts-1">SpringCloudBuilder#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudBuilderState<'BuildPackGroup, 'Name, 'SpringCloudServiceId, 'Stack>, value: azurerm.SpringCloudBuilder.SpringCloudBuilderTimeouts) : SpringCloudBuilderState<'BuildPackGroup, 'Name, 'SpringCloudServiceId, 'Stack> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudBuilderState<'BuildPackGroup, 'Name, 'SpringCloudServiceId, 'Stack>

        member _.Run(state: SpringCloudBuilderState<Present, Present, Present, Present>) : azurerm.SpringCloudBuilder.SpringCloudBuilder =
            let config = azurerm.SpringCloudBuilder.SpringCloudBuilderConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudBuilder.SpringCloudBuilder(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudBuilder: missing required arguments. Must call: build_pack_group, name, spring_cloud_service_id, stack.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudBuilderState<_, _, _, _>) : azurerm.SpringCloudBuilder.SpringCloudBuilder =
            Unchecked.defaultof<azurerm.SpringCloudBuilder.SpringCloudBuilder>
