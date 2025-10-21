namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermApplicationInsightsState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermApplicationInsights.DataAzurermApplicationInsightsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_insights">azurerm_application_insights</a>.
    /// </summary>
    type DataAzurermApplicationInsightsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermApplicationInsightsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApplicationInsightsState<Missing, Missing>)

        member _.Zero(()) : DataAzurermApplicationInsightsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApplicationInsightsState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_insights#name-1">DataAzurermApplicationInsights#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermApplicationInsightsState<Missing, 'ResourceGroupName>, value: string) : DataAzurermApplicationInsightsState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermApplicationInsightsState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_insights#resource_group_name-1">DataAzurermApplicationInsights#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermApplicationInsightsState<'Name, Missing>, value: string) : DataAzurermApplicationInsightsState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermApplicationInsightsState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_insights#id-1">DataAzurermApplicationInsights#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermApplicationInsightsState<'Name, 'ResourceGroupName>, value: string) : DataAzurermApplicationInsightsState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermApplicationInsightsState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_insights#timeouts-1">DataAzurermApplicationInsights#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermApplicationInsightsState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermApplicationInsights.DataAzurermApplicationInsightsTimeouts) : DataAzurermApplicationInsightsState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermApplicationInsightsState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermApplicationInsightsState<Present, Present>) : azurerm.DataAzurermApplicationInsights.DataAzurermApplicationInsights =
            let config = azurerm.DataAzurermApplicationInsights.DataAzurermApplicationInsightsConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermApplicationInsights.DataAzurermApplicationInsights(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermApplicationInsights: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermApplicationInsightsState<_, _>) : azurerm.DataAzurermApplicationInsights.DataAzurermApplicationInsights =
            Unchecked.defaultof<azurerm.DataAzurermApplicationInsights.DataAzurermApplicationInsights>
