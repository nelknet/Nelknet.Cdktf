namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> = { assignments: ResizeArray<azurerm.AutomationAccount.AutomationAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_account">azurerm_automation_account</a>.
    /// </summary>
    type AutomationAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationAccountState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationAccountState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AutomationAccountState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationAccountState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_account#location-1">AutomationAccount#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: AutomationAccountState<Missing, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : AutomationAccountState<Present, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : AutomationAccountState<Present, 'Name, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_account#name-1">AutomationAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationAccountState<'Location, Missing, 'ResourceGroupName, 'SkuName>, value: string) : AutomationAccountState<'Location, Present, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationAccountState<'Location, Present, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_account#resource_group_name-1">AutomationAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationAccountState<'Location, 'Name, Missing, 'SkuName>, value: string) : AutomationAccountState<'Location, 'Name, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationAccountState<'Location, 'Name, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_account#sku_name-1">AutomationAccount#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: AutomationAccountState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : AutomationAccountState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : AutomationAccountState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// encryption block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_account#encryption-1">AutomationAccount#encryption</a> Accepts: azurerm.IResolvable | azurerm.AutomationAccount.AutomationAccountEncryption[]
        /// </summary>
        [<CustomOperation "encryption">]
        member _.Encryption(state: AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Encryption <- value)
            state : AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_account#id-1">AutomationAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_account#identity-1">AutomationAccount#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.AutomationAccount.AutomationAccountIdentity) : AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_account#local_authentication_enabled-1">AutomationAccount#local_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_authentication_enabled">]
        member _.LocalAuthenticationEnabled(state: AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: bool) : AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.LocalAuthenticationEnabled <- value)
            state : AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_account#local_authentication_enabled-1">AutomationAccount#local_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_authentication_enabled">]
        member _.LocalAuthenticationEnabled(state: AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.LocalAuthenticationEnabled <- value)
            state : AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_account#public_network_access_enabled-1">AutomationAccount#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: bool) : AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_account#public_network_access_enabled-1">AutomationAccount#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_account#tags-1">AutomationAccount#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_account#timeouts-1">AutomationAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.AutomationAccount.AutomationAccountTimeouts) : AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        member _.Run(state: AutomationAccountState<Present, Present, Present, Present>) : azurerm.AutomationAccount.AutomationAccount =
            let config = azurerm.AutomationAccount.AutomationAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationAccount.AutomationAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationAccount: missing required arguments. Must call: location, name, resource_group_name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: AutomationAccountState<_, _, _, _>) : azurerm.AutomationAccount.AutomationAccount =
            Unchecked.defaultof<azurerm.AutomationAccount.AutomationAccount>
