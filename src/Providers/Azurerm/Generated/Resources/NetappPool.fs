namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb> = { assignments: ResizeArray<azurerm.NetappPool.NetappPoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_pool">azurerm_netapp_pool</a>.
    /// </summary>
    type NetappPoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetappPoolState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetappPoolState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetappPoolState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetappPoolState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_pool#account_name-1">NetappPool#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: NetappPoolState<Missing, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb>, value: string) : NetappPoolState<Present, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : NetappPoolState<Present, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_pool#location-1">NetappPool#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NetappPoolState<'AccountName, Missing, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb>, value: string) : NetappPoolState<'AccountName, Present, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NetappPoolState<'AccountName, Present, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_pool#name-1">NetappPool#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetappPoolState<'AccountName, 'Location, Missing, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb>, value: string) : NetappPoolState<'AccountName, 'Location, Present, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetappPoolState<'AccountName, 'Location, Present, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_pool#resource_group_name-1">NetappPool#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NetappPoolState<'AccountName, 'Location, 'Name, Missing, 'ServiceLevel, 'SizeInTb>, value: string) : NetappPoolState<'AccountName, 'Location, 'Name, Present, 'ServiceLevel, 'SizeInTb> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NetappPoolState<'AccountName, 'Location, 'Name, Present, 'ServiceLevel, 'SizeInTb>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_pool#service_level-1">NetappPool#service_level</a>.
        /// </summary>
        [<CustomOperation "service_level">]
        member _.ServiceLevel(state: NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, Missing, 'SizeInTb>, value: string) : NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, Present, 'SizeInTb> =
            state.assignments.Add(fun config -> config.ServiceLevel <- value)
            ({ assignments = state.assignments } : NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, Present, 'SizeInTb>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_pool#size_in_tb-1">NetappPool#size_in_tb</a>.
        /// </summary>
        [<CustomOperation "size_in_tb">]
        member _.SizeInTb(state: NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, Missing>, value: double) : NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, Present> =
            state.assignments.Add(fun config -> config.SizeInTb <- value)
            ({ assignments = state.assignments } : NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_pool#encryption_type-1">NetappPool#encryption_type</a>.
        /// </summary>
        [<CustomOperation "encryption_type">]
        member _.EncryptionType(state: NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb>, value: string) : NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb> =
            state.assignments.Add(fun config -> config.EncryptionType <- value)
            state : NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_pool#id-1">NetappPool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb>, value: string) : NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_pool#qos_type-1">NetappPool#qos_type</a>.
        /// </summary>
        [<CustomOperation "qos_type">]
        member _.QosType(state: NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb>, value: string) : NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb> =
            state.assignments.Add(fun config -> config.QosType <- value)
            state : NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_pool#tags-1">NetappPool#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb>, value: seq<string * string>) : NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_pool#timeouts-1">NetappPool#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb>, value: azurerm.NetappPool.NetappPoolTimeouts) : NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetappPoolState<'AccountName, 'Location, 'Name, 'ResourceGroupName, 'ServiceLevel, 'SizeInTb>

        member _.Run(state: NetappPoolState<Present, Present, Present, Present, Present, Present>) : azurerm.NetappPool.NetappPool =
            let config = azurerm.NetappPool.NetappPoolConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetappPool.NetappPool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.netappPool: missing required arguments. Must call: account_name, location, name, resource_group_name, service_level, size_in_tb.", 9999, IsError = true)>]
        member _.Run(_: NetappPoolState<_, _, _, _, _, _>) : azurerm.NetappPool.NetappPool =
            Unchecked.defaultof<azurerm.NetappPool.NetappPool>
