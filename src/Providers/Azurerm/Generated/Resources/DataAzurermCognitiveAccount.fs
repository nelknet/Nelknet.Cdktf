namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermCognitiveAccountState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermCognitiveAccount.DataAzurermCognitiveAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cognitive_account">azurerm_cognitive_account</a>.
    /// </summary>
    type DataAzurermCognitiveAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermCognitiveAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCognitiveAccountState<Missing, Missing>)

        member _.Zero(()) : DataAzurermCognitiveAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCognitiveAccountState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cognitive_account#name-1">DataAzurermCognitiveAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermCognitiveAccountState<Missing, 'ResourceGroupName>, value: string) : DataAzurermCognitiveAccountState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermCognitiveAccountState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cognitive_account#resource_group_name-1">DataAzurermCognitiveAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermCognitiveAccountState<'Name, Missing>, value: string) : DataAzurermCognitiveAccountState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermCognitiveAccountState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cognitive_account#id-1">DataAzurermCognitiveAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermCognitiveAccountState<'Name, 'ResourceGroupName>, value: string) : DataAzurermCognitiveAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermCognitiveAccountState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cognitive_account#tags-1">DataAzurermCognitiveAccount#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAzurermCognitiveAccountState<'Name, 'ResourceGroupName>, value: seq<string * string>) : DataAzurermCognitiveAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAzurermCognitiveAccountState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cognitive_account#timeouts-1">DataAzurermCognitiveAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermCognitiveAccountState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermCognitiveAccount.DataAzurermCognitiveAccountTimeouts) : DataAzurermCognitiveAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermCognitiveAccountState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermCognitiveAccountState<Present, Present>) : azurerm.DataAzurermCognitiveAccount.DataAzurermCognitiveAccount =
            let config = azurerm.DataAzurermCognitiveAccount.DataAzurermCognitiveAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermCognitiveAccount.DataAzurermCognitiveAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermCognitiveAccount: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermCognitiveAccountState<_, _>) : azurerm.DataAzurermCognitiveAccount.DataAzurermCognitiveAccount =
            Unchecked.defaultof<azurerm.DataAzurermCognitiveAccount.DataAzurermCognitiveAccount>
