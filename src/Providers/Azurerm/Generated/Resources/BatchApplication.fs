namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BatchApplicationState<'AccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.BatchApplication.BatchApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_application">azurerm_batch_application</a>.
    /// </summary>
    type BatchApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : BatchApplicationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BatchApplicationState<Missing, Missing, Missing>)

        member _.Zero(()) : BatchApplicationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BatchApplicationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_application#account_name-1">BatchApplication#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: BatchApplicationState<Missing, 'Name, 'ResourceGroupName>, value: string) : BatchApplicationState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : BatchApplicationState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_application#name-1">BatchApplication#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BatchApplicationState<'AccountName, Missing, 'ResourceGroupName>, value: string) : BatchApplicationState<'AccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BatchApplicationState<'AccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_application#resource_group_name-1">BatchApplication#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BatchApplicationState<'AccountName, 'Name, Missing>, value: string) : BatchApplicationState<'AccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BatchApplicationState<'AccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_application#allow_updates-1">BatchApplication#allow_updates</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_updates">]
        member _.AllowUpdates(state: BatchApplicationState<'AccountName, 'Name, 'ResourceGroupName>, value: bool) : BatchApplicationState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AllowUpdates <- value)
            state : BatchApplicationState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_application#allow_updates-1">BatchApplication#allow_updates</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_updates">]
        member _.AllowUpdates(state: BatchApplicationState<'AccountName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : BatchApplicationState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AllowUpdates <- value)
            state : BatchApplicationState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_application#default_version-1">BatchApplication#default_version</a>.
        /// </summary>
        [<CustomOperation "default_version">]
        member _.DefaultVersion(state: BatchApplicationState<'AccountName, 'Name, 'ResourceGroupName>, value: string) : BatchApplicationState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DefaultVersion <- value)
            state : BatchApplicationState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_application#display_name-1">BatchApplication#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: BatchApplicationState<'AccountName, 'Name, 'ResourceGroupName>, value: string) : BatchApplicationState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : BatchApplicationState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_application#id-1">BatchApplication#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BatchApplicationState<'AccountName, 'Name, 'ResourceGroupName>, value: string) : BatchApplicationState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BatchApplicationState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_application#timeouts-1">BatchApplication#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BatchApplicationState<'AccountName, 'Name, 'ResourceGroupName>, value: azurerm.BatchApplication.BatchApplicationTimeouts) : BatchApplicationState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BatchApplicationState<'AccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: BatchApplicationState<Present, Present, Present>) : azurerm.BatchApplication.BatchApplication =
            let config = azurerm.BatchApplication.BatchApplicationConfig()
            for setter in state.assignments do
                setter config
            azurerm.BatchApplication.BatchApplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.batchApplication: missing required arguments. Must call: account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: BatchApplicationState<_, _, _>) : azurerm.BatchApplication.BatchApplication =
            Unchecked.defaultof<azurerm.BatchApplication.BatchApplication>
