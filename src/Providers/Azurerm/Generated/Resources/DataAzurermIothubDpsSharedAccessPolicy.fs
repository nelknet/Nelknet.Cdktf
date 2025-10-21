namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermIothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermIothubDpsSharedAccessPolicy.DataAzurermIothubDpsSharedAccessPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub_dps_shared_access_policy">azurerm_iothub_dps_shared_access_policy</a>.
    /// </summary>
    type DataAzurermIothubDpsSharedAccessPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermIothubDpsSharedAccessPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermIothubDpsSharedAccessPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermIothubDpsSharedAccessPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermIothubDpsSharedAccessPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub_dps_shared_access_policy#iothub_dps_name-1">DataAzurermIothubDpsSharedAccessPolicy#iothub_dps_name</a>.
        /// </summary>
        [<CustomOperation "iothub_dps_name">]
        member _.IothubDpsName(state: DataAzurermIothubDpsSharedAccessPolicyState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermIothubDpsSharedAccessPolicyState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IothubDpsName <- value)
            ({ assignments = state.assignments } : DataAzurermIothubDpsSharedAccessPolicyState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub_dps_shared_access_policy#name-1">DataAzurermIothubDpsSharedAccessPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermIothubDpsSharedAccessPolicyState<'IothubDpsName, Missing, 'ResourceGroupName>, value: string) : DataAzurermIothubDpsSharedAccessPolicyState<'IothubDpsName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermIothubDpsSharedAccessPolicyState<'IothubDpsName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub_dps_shared_access_policy#resource_group_name-1">DataAzurermIothubDpsSharedAccessPolicy#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermIothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, Missing>, value: string) : DataAzurermIothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermIothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub_dps_shared_access_policy#id-1">DataAzurermIothubDpsSharedAccessPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermIothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermIothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermIothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub_dps_shared_access_policy#timeouts-1">DataAzurermIothubDpsSharedAccessPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermIothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermIothubDpsSharedAccessPolicy.DataAzurermIothubDpsSharedAccessPolicyTimeouts) : DataAzurermIothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermIothubDpsSharedAccessPolicyState<'IothubDpsName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermIothubDpsSharedAccessPolicyState<Present, Present, Present>) : azurerm.DataAzurermIothubDpsSharedAccessPolicy.DataAzurermIothubDpsSharedAccessPolicy =
            let config = azurerm.DataAzurermIothubDpsSharedAccessPolicy.DataAzurermIothubDpsSharedAccessPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermIothubDpsSharedAccessPolicy.DataAzurermIothubDpsSharedAccessPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermIothubDpsSharedAccessPolicy: missing required arguments. Must call: iothub_dps_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermIothubDpsSharedAccessPolicyState<_, _, _>) : azurerm.DataAzurermIothubDpsSharedAccessPolicy.DataAzurermIothubDpsSharedAccessPolicy =
            Unchecked.defaultof<azurerm.DataAzurermIothubDpsSharedAccessPolicy.DataAzurermIothubDpsSharedAccessPolicy>
