namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudBuildPackBindingState<'Name, 'SpringCloudBuilderId> = { assignments: ResizeArray<azurerm.SpringCloudBuildPackBinding.SpringCloudBuildPackBindingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_pack_binding">azurerm_spring_cloud_build_pack_binding</a>.
    /// </summary>
    type SpringCloudBuildPackBindingBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudBuildPackBindingState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudBuildPackBindingState<Missing, Missing>)

        member _.Zero(()) : SpringCloudBuildPackBindingState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudBuildPackBindingState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_pack_binding#name-1">SpringCloudBuildPackBinding#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudBuildPackBindingState<Missing, 'SpringCloudBuilderId>, value: string) : SpringCloudBuildPackBindingState<Present, 'SpringCloudBuilderId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudBuildPackBindingState<Present, 'SpringCloudBuilderId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_pack_binding#spring_cloud_builder_id-1">SpringCloudBuildPackBinding#spring_cloud_builder_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_builder_id">]
        member _.SpringCloudBuilderId(state: SpringCloudBuildPackBindingState<'Name, Missing>, value: string) : SpringCloudBuildPackBindingState<'Name, Present> =
            state.assignments.Add(fun config -> config.SpringCloudBuilderId <- value)
            ({ assignments = state.assignments } : SpringCloudBuildPackBindingState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_pack_binding#binding_type-1">SpringCloudBuildPackBinding#binding_type</a>.
        /// </summary>
        [<CustomOperation "binding_type">]
        member _.BindingType(state: SpringCloudBuildPackBindingState<'Name, 'SpringCloudBuilderId>, value: string) : SpringCloudBuildPackBindingState<'Name, 'SpringCloudBuilderId> =
            state.assignments.Add(fun config -> config.BindingType <- value)
            state : SpringCloudBuildPackBindingState<'Name, 'SpringCloudBuilderId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_pack_binding#id-1">SpringCloudBuildPackBinding#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudBuildPackBindingState<'Name, 'SpringCloudBuilderId>, value: string) : SpringCloudBuildPackBindingState<'Name, 'SpringCloudBuilderId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudBuildPackBindingState<'Name, 'SpringCloudBuilderId>

        /// <summary>
        /// launch block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_pack_binding#launch-1">SpringCloudBuildPackBinding#launch</a>
        /// </summary>
        [<CustomOperation "launch">]
        member _.Launch(state: SpringCloudBuildPackBindingState<'Name, 'SpringCloudBuilderId>, value: azurerm.SpringCloudBuildPackBinding.SpringCloudBuildPackBindingLaunch) : SpringCloudBuildPackBindingState<'Name, 'SpringCloudBuilderId> =
            state.assignments.Add(fun config -> config.Launch <- value)
            state : SpringCloudBuildPackBindingState<'Name, 'SpringCloudBuilderId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_pack_binding#timeouts-1">SpringCloudBuildPackBinding#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudBuildPackBindingState<'Name, 'SpringCloudBuilderId>, value: azurerm.SpringCloudBuildPackBinding.SpringCloudBuildPackBindingTimeouts) : SpringCloudBuildPackBindingState<'Name, 'SpringCloudBuilderId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudBuildPackBindingState<'Name, 'SpringCloudBuilderId>

        member _.Run(state: SpringCloudBuildPackBindingState<Present, Present>) : azurerm.SpringCloudBuildPackBinding.SpringCloudBuildPackBinding =
            let config = azurerm.SpringCloudBuildPackBinding.SpringCloudBuildPackBindingConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudBuildPackBinding.SpringCloudBuildPackBinding(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudBuildPackBinding: missing required arguments. Must call: name, spring_cloud_builder_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudBuildPackBindingState<_, _>) : azurerm.SpringCloudBuildPackBinding.SpringCloudBuildPackBinding =
            Unchecked.defaultof<azurerm.SpringCloudBuildPackBinding.SpringCloudBuildPackBinding>
