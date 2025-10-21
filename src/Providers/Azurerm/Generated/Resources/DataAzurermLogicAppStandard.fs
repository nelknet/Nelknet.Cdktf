namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermLogicAppStandardState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermLogicAppStandard.DataAzurermLogicAppStandardConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_standard">azurerm_logic_app_standard</a>.
    /// </summary>
    type DataAzurermLogicAppStandardBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermLogicAppStandardState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLogicAppStandardState<Missing, Missing>)

        member _.Zero(()) : DataAzurermLogicAppStandardState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLogicAppStandardState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_standard#name-1">DataAzurermLogicAppStandard#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermLogicAppStandardState<Missing, 'ResourceGroupName>, value: string) : DataAzurermLogicAppStandardState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermLogicAppStandardState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_standard#resource_group_name-1">DataAzurermLogicAppStandard#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermLogicAppStandardState<'Name, Missing>, value: string) : DataAzurermLogicAppStandardState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermLogicAppStandardState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_standard#id-1">DataAzurermLogicAppStandard#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermLogicAppStandardState<'Name, 'ResourceGroupName>, value: string) : DataAzurermLogicAppStandardState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermLogicAppStandardState<'Name, 'ResourceGroupName>

        /// <summary>
        /// site_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_standard#site_config-1">DataAzurermLogicAppStandard#site_config</a>
        /// </summary>
        [<CustomOperation "site_config">]
        member _.SiteConfig(state: DataAzurermLogicAppStandardState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermLogicAppStandard.DataAzurermLogicAppStandardSiteConfig) : DataAzurermLogicAppStandardState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SiteConfig <- value)
            state : DataAzurermLogicAppStandardState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_standard#tags-1">DataAzurermLogicAppStandard#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAzurermLogicAppStandardState<'Name, 'ResourceGroupName>, value: seq<string * string>) : DataAzurermLogicAppStandardState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAzurermLogicAppStandardState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_standard#timeouts-1">DataAzurermLogicAppStandard#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermLogicAppStandardState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermLogicAppStandard.DataAzurermLogicAppStandardTimeouts) : DataAzurermLogicAppStandardState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermLogicAppStandardState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermLogicAppStandardState<Present, Present>) : azurerm.DataAzurermLogicAppStandard.DataAzurermLogicAppStandard =
            let config = azurerm.DataAzurermLogicAppStandard.DataAzurermLogicAppStandardConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermLogicAppStandard.DataAzurermLogicAppStandard(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermLogicAppStandard: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermLogicAppStandardState<_, _>) : azurerm.DataAzurermLogicAppStandard.DataAzurermLogicAppStandard =
            Unchecked.defaultof<azurerm.DataAzurermLogicAppStandard.DataAzurermLogicAppStandard>
