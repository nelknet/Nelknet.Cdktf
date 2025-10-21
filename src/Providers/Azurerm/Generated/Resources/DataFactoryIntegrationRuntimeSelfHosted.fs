namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryIntegrationRuntimeSelfHosted.DataFactoryIntegrationRuntimeSelfHostedConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_self_hosted">azurerm_data_factory_integration_runtime_self_hosted</a>.
    /// </summary>
    type DataFactoryIntegrationRuntimeSelfHostedBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryIntegrationRuntimeSelfHostedState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryIntegrationRuntimeSelfHostedState<Missing, Missing>)

        member _.Zero(()) : DataFactoryIntegrationRuntimeSelfHostedState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryIntegrationRuntimeSelfHostedState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_self_hosted#data_factory_id-1">DataFactoryIntegrationRuntimeSelfHosted#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryIntegrationRuntimeSelfHostedState<Missing, 'Name>, value: string) : DataFactoryIntegrationRuntimeSelfHostedState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryIntegrationRuntimeSelfHostedState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_self_hosted#name-1">DataFactoryIntegrationRuntimeSelfHosted#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, Missing>, value: string) : DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_self_hosted#description-1">DataFactoryIntegrationRuntimeSelfHosted#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, 'Name>, value: string) : DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_self_hosted#id-1">DataFactoryIntegrationRuntimeSelfHosted#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, 'Name>, value: string) : DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, 'Name>

        /// <summary>
        /// rbac_authorization block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_self_hosted#rbac_authorization-1">DataFactoryIntegrationRuntimeSelfHosted#rbac_authorization</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryIntegrationRuntimeSelfHosted.DataFactoryIntegrationRuntimeSelfHostedRbacAuthorization[]
        /// </summary>
        [<CustomOperation "rbac_authorization">]
        member _.RbacAuthorization(state: DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.RbacAuthorization <- value)
            state : DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_self_hosted#self_contained_interactive_authoring_enabled-1">DataFactoryIntegrationRuntimeSelfHosted#self_contained_interactive_authoring_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "self_contained_interactive_authoring_enabled">]
        member _.SelfContainedInteractiveAuthoringEnabled(state: DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, 'Name>, value: bool) : DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.SelfContainedInteractiveAuthoringEnabled <- value)
            state : DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_self_hosted#self_contained_interactive_authoring_enabled-1">DataFactoryIntegrationRuntimeSelfHosted#self_contained_interactive_authoring_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "self_contained_interactive_authoring_enabled">]
        member _.SelfContainedInteractiveAuthoringEnabled(state: DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.SelfContainedInteractiveAuthoringEnabled <- value)
            state : DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_self_hosted#timeouts-1">DataFactoryIntegrationRuntimeSelfHosted#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, 'Name>, value: azurerm.DataFactoryIntegrationRuntimeSelfHosted.DataFactoryIntegrationRuntimeSelfHostedTimeouts) : DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryIntegrationRuntimeSelfHostedState<'DataFactoryId, 'Name>

        member _.Run(state: DataFactoryIntegrationRuntimeSelfHostedState<Present, Present>) : azurerm.DataFactoryIntegrationRuntimeSelfHosted.DataFactoryIntegrationRuntimeSelfHosted =
            let config = azurerm.DataFactoryIntegrationRuntimeSelfHosted.DataFactoryIntegrationRuntimeSelfHostedConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryIntegrationRuntimeSelfHosted.DataFactoryIntegrationRuntimeSelfHosted(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryIntegrationRuntimeSelfHosted: missing required arguments. Must call: data_factory_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryIntegrationRuntimeSelfHostedState<_, _>) : azurerm.DataFactoryIntegrationRuntimeSelfHosted.DataFactoryIntegrationRuntimeSelfHosted =
            Unchecked.defaultof<azurerm.DataFactoryIntegrationRuntimeSelfHosted.DataFactoryIntegrationRuntimeSelfHosted>
