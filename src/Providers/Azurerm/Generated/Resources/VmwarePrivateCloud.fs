namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName> = { assignments: ResizeArray<azurerm.VmwarePrivateCloud.VmwarePrivateCloudConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_private_cloud">azurerm_vmware_private_cloud</a>.
    /// </summary>
    type VmwarePrivateCloudBuilder(logicalId: string) =
        member _.Yield(_: unit) : VmwarePrivateCloudState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VmwarePrivateCloudState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VmwarePrivateCloudState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VmwarePrivateCloudState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_private_cloud#location-1">VmwarePrivateCloud#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: VmwarePrivateCloudState<Missing, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName>, value: string) : VmwarePrivateCloudState<Present, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : VmwarePrivateCloudState<Present, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// management_cluster block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_private_cloud#management_cluster-1">VmwarePrivateCloud#management_cluster</a>
        /// </summary>
        [<CustomOperation "management_cluster">]
        member _.ManagementCluster(state: VmwarePrivateCloudState<'Location, Missing, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName>, value: azurerm.VmwarePrivateCloud.VmwarePrivateCloudManagementCluster) : VmwarePrivateCloudState<'Location, Present, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.ManagementCluster <- value)
            ({ assignments = state.assignments } : VmwarePrivateCloudState<'Location, Present, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_private_cloud#name-1">VmwarePrivateCloud#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VmwarePrivateCloudState<'Location, 'ManagementCluster, Missing, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName>, value: string) : VmwarePrivateCloudState<'Location, 'ManagementCluster, Present, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VmwarePrivateCloudState<'Location, 'ManagementCluster, Present, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_private_cloud#network_subnet_cidr-1">VmwarePrivateCloud#network_subnet_cidr</a>.
        /// </summary>
        [<CustomOperation "network_subnet_cidr">]
        member _.NetworkSubnetCidr(state: VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, Missing, 'ResourceGroupName, 'SkuName>, value: string) : VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, Present, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.NetworkSubnetCidr <- value)
            ({ assignments = state.assignments } : VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, Present, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_private_cloud#resource_group_name-1">VmwarePrivateCloud#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, Missing, 'SkuName>, value: string) : VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_private_cloud#sku_name-1">VmwarePrivateCloud#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, Missing>, value: string) : VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_private_cloud#id-1">VmwarePrivateCloud#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName>, value: string) : VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_private_cloud#internet_connection_enabled-1">VmwarePrivateCloud#internet_connection_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "internet_connection_enabled">]
        member _.InternetConnectionEnabled(state: VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName>, value: bool) : VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.InternetConnectionEnabled <- value)
            state : VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_private_cloud#internet_connection_enabled-1">VmwarePrivateCloud#internet_connection_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "internet_connection_enabled">]
        member _.InternetConnectionEnabled(state: VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.InternetConnectionEnabled <- value)
            state : VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_private_cloud#nsxt_password-1">VmwarePrivateCloud#nsxt_password</a>.
        /// </summary>
        [<CustomOperation "nsxt_password">]
        member _.NsxtPassword(state: VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName>, value: string) : VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.NsxtPassword <- value)
            state : VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_private_cloud#tags-1">VmwarePrivateCloud#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_private_cloud#timeouts-1">VmwarePrivateCloud#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName>, value: azurerm.VmwarePrivateCloud.VmwarePrivateCloudTimeouts) : VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_private_cloud#vcenter_password-1">VmwarePrivateCloud#vcenter_password</a>.
        /// </summary>
        [<CustomOperation "vcenter_password">]
        member _.VcenterPassword(state: VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName>, value: string) : VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.VcenterPassword <- value)
            state : VmwarePrivateCloudState<'Location, 'ManagementCluster, 'Name, 'NetworkSubnetCidr, 'ResourceGroupName, 'SkuName>

        member _.Run(state: VmwarePrivateCloudState<Present, Present, Present, Present, Present, Present>) : azurerm.VmwarePrivateCloud.VmwarePrivateCloud =
            let config = azurerm.VmwarePrivateCloud.VmwarePrivateCloudConfig()
            for setter in state.assignments do
                setter config
            azurerm.VmwarePrivateCloud.VmwarePrivateCloud(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.vmwarePrivateCloud: missing required arguments. Must call: location, management_cluster, name, network_subnet_cidr, resource_group_name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: VmwarePrivateCloudState<_, _, _, _, _, _>) : azurerm.VmwarePrivateCloud.VmwarePrivateCloud =
            Unchecked.defaultof<azurerm.VmwarePrivateCloud.VmwarePrivateCloud>
