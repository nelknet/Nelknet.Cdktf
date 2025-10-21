namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermIothubSharedAccessPolicyState<'IothubName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermIothubSharedAccessPolicy.DataAzurermIothubSharedAccessPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub_shared_access_policy">azurerm_iothub_shared_access_policy</a>.
    /// </summary>
    type DataAzurermIothubSharedAccessPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermIothubSharedAccessPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermIothubSharedAccessPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermIothubSharedAccessPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermIothubSharedAccessPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub_shared_access_policy#iothub_name-1">DataAzurermIothubSharedAccessPolicy#iothub_name</a>.
        /// </summary>
        [<CustomOperation "iothub_name">]
        member _.IothubName(state: DataAzurermIothubSharedAccessPolicyState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermIothubSharedAccessPolicyState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IothubName <- value)
            ({ assignments = state.assignments } : DataAzurermIothubSharedAccessPolicyState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub_shared_access_policy#name-1">DataAzurermIothubSharedAccessPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermIothubSharedAccessPolicyState<'IothubName, Missing, 'ResourceGroupName>, value: string) : DataAzurermIothubSharedAccessPolicyState<'IothubName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermIothubSharedAccessPolicyState<'IothubName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub_shared_access_policy#resource_group_name-1">DataAzurermIothubSharedAccessPolicy#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermIothubSharedAccessPolicyState<'IothubName, 'Name, Missing>, value: string) : DataAzurermIothubSharedAccessPolicyState<'IothubName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermIothubSharedAccessPolicyState<'IothubName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub_shared_access_policy#id-1">DataAzurermIothubSharedAccessPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermIothubSharedAccessPolicyState<'IothubName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermIothubSharedAccessPolicyState<'IothubName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermIothubSharedAccessPolicyState<'IothubName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub_shared_access_policy#timeouts-1">DataAzurermIothubSharedAccessPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermIothubSharedAccessPolicyState<'IothubName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermIothubSharedAccessPolicy.DataAzurermIothubSharedAccessPolicyTimeouts) : DataAzurermIothubSharedAccessPolicyState<'IothubName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermIothubSharedAccessPolicyState<'IothubName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermIothubSharedAccessPolicyState<Present, Present, Present>) : azurerm.DataAzurermIothubSharedAccessPolicy.DataAzurermIothubSharedAccessPolicy =
            let config = azurerm.DataAzurermIothubSharedAccessPolicy.DataAzurermIothubSharedAccessPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermIothubSharedAccessPolicy.DataAzurermIothubSharedAccessPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermIothubSharedAccessPolicy: missing required arguments. Must call: iothub_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermIothubSharedAccessPolicyState<_, _, _>) : azurerm.DataAzurermIothubSharedAccessPolicy.DataAzurermIothubSharedAccessPolicy =
            Unchecked.defaultof<azurerm.DataAzurermIothubSharedAccessPolicy.DataAzurermIothubSharedAccessPolicy>
