namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSubscriptionTemplateDeploymentState<'Name> = { assignments: ResizeArray<azurerm.DataAzurermSubscriptionTemplateDeployment.DataAzurermSubscriptionTemplateDeploymentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subscription_template_deployment">azurerm_subscription_template_deployment</a>.
    /// </summary>
    type DataAzurermSubscriptionTemplateDeploymentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSubscriptionTemplateDeploymentState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSubscriptionTemplateDeploymentState<Missing>)

        member _.Zero(()) : DataAzurermSubscriptionTemplateDeploymentState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSubscriptionTemplateDeploymentState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subscription_template_deployment#name-1">DataAzurermSubscriptionTemplateDeployment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermSubscriptionTemplateDeploymentState<Missing>, value: string) : DataAzurermSubscriptionTemplateDeploymentState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermSubscriptionTemplateDeploymentState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subscription_template_deployment#id-1">DataAzurermSubscriptionTemplateDeployment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSubscriptionTemplateDeploymentState<'Name>, value: string) : DataAzurermSubscriptionTemplateDeploymentState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSubscriptionTemplateDeploymentState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subscription_template_deployment#timeouts-1">DataAzurermSubscriptionTemplateDeployment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSubscriptionTemplateDeploymentState<'Name>, value: azurerm.DataAzurermSubscriptionTemplateDeployment.DataAzurermSubscriptionTemplateDeploymentTimeouts) : DataAzurermSubscriptionTemplateDeploymentState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSubscriptionTemplateDeploymentState<'Name>

        member _.Run(state: DataAzurermSubscriptionTemplateDeploymentState<Present>) : azurerm.DataAzurermSubscriptionTemplateDeployment.DataAzurermSubscriptionTemplateDeployment =
            let config = azurerm.DataAzurermSubscriptionTemplateDeployment.DataAzurermSubscriptionTemplateDeploymentConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSubscriptionTemplateDeployment.DataAzurermSubscriptionTemplateDeployment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermSubscriptionTemplateDeployment: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermSubscriptionTemplateDeploymentState<_>) : azurerm.DataAzurermSubscriptionTemplateDeployment.DataAzurermSubscriptionTemplateDeployment =
            Unchecked.defaultof<azurerm.DataAzurermSubscriptionTemplateDeployment.DataAzurermSubscriptionTemplateDeployment>
