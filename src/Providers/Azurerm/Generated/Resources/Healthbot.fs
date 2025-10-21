namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type HealthbotState<'Location, 'Name, 'ResourceGroupName, 'SkuName> = { assignments: ResizeArray<azurerm.Healthbot.HealthbotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthbot">azurerm_healthbot</a>.
    /// </summary>
    type HealthbotBuilder(logicalId: string) =
        member _.Yield(_: unit) : HealthbotState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HealthbotState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : HealthbotState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HealthbotState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthbot#location-1">Healthbot#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: HealthbotState<Missing, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : HealthbotState<Present, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : HealthbotState<Present, 'Name, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthbot#name-1">Healthbot#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: HealthbotState<'Location, Missing, 'ResourceGroupName, 'SkuName>, value: string) : HealthbotState<'Location, Present, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : HealthbotState<'Location, Present, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthbot#resource_group_name-1">Healthbot#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: HealthbotState<'Location, 'Name, Missing, 'SkuName>, value: string) : HealthbotState<'Location, 'Name, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : HealthbotState<'Location, 'Name, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthbot#sku_name-1">Healthbot#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: HealthbotState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : HealthbotState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : HealthbotState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthbot#id-1">Healthbot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: HealthbotState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : HealthbotState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : HealthbotState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthbot#tags-1">Healthbot#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: HealthbotState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : HealthbotState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : HealthbotState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthbot#timeouts-1">Healthbot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: HealthbotState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.Healthbot.HealthbotTimeouts) : HealthbotState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : HealthbotState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        member _.Run(state: HealthbotState<Present, Present, Present, Present>) : azurerm.Healthbot.Healthbot =
            let config = azurerm.Healthbot.HealthbotConfig()
            for setter in state.assignments do
                setter config
            azurerm.Healthbot.Healthbot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.healthbot: missing required arguments. Must call: location, name, resource_group_name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: HealthbotState<_, _, _, _>) : azurerm.Healthbot.Healthbot =
            Unchecked.defaultof<azurerm.Healthbot.Healthbot>
