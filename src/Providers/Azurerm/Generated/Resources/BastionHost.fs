namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BastionHostState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.BastionHost.BastionHostConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host">azurerm_bastion_host</a>.
    /// </summary>
    type BastionHostBuilder(logicalId: string) =
        member _.Yield(_: unit) : BastionHostState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BastionHostState<Missing, Missing, Missing>)

        member _.Zero(()) : BastionHostState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BastionHostState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#location-1">BastionHost#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: BastionHostState<Missing, 'Name, 'ResourceGroupName>, value: string) : BastionHostState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : BastionHostState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#name-1">BastionHost#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BastionHostState<'Location, Missing, 'ResourceGroupName>, value: string) : BastionHostState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BastionHostState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#resource_group_name-1">BastionHost#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BastionHostState<'Location, 'Name, Missing>, value: string) : BastionHostState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BastionHostState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#copy_paste_enabled-1">BastionHost#copy_paste_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "copy_paste_enabled">]
        member _.CopyPasteEnabled(state: BastionHostState<'Location, 'Name, 'ResourceGroupName>, value: bool) : BastionHostState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CopyPasteEnabled <- value)
            state : BastionHostState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#copy_paste_enabled-1">BastionHost#copy_paste_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "copy_paste_enabled">]
        member _.CopyPasteEnabled(state: BastionHostState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : BastionHostState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CopyPasteEnabled <- value)
            state : BastionHostState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#file_copy_enabled-1">BastionHost#file_copy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "file_copy_enabled">]
        member _.FileCopyEnabled(state: BastionHostState<'Location, 'Name, 'ResourceGroupName>, value: bool) : BastionHostState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FileCopyEnabled <- value)
            state : BastionHostState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#file_copy_enabled-1">BastionHost#file_copy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "file_copy_enabled">]
        member _.FileCopyEnabled(state: BastionHostState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : BastionHostState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FileCopyEnabled <- value)
            state : BastionHostState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#id-1">BastionHost#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BastionHostState<'Location, 'Name, 'ResourceGroupName>, value: string) : BastionHostState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BastionHostState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// ip_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#ip_configuration-1">BastionHost#ip_configuration</a>
        /// </summary>
        [<CustomOperation "ip_configuration">]
        member _.IpConfiguration(state: BastionHostState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.BastionHost.BastionHostIpConfiguration) : BastionHostState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IpConfiguration <- value)
            state : BastionHostState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#ip_connect_enabled-1">BastionHost#ip_connect_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ip_connect_enabled">]
        member _.IpConnectEnabled(state: BastionHostState<'Location, 'Name, 'ResourceGroupName>, value: bool) : BastionHostState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IpConnectEnabled <- value)
            state : BastionHostState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#ip_connect_enabled-1">BastionHost#ip_connect_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ip_connect_enabled">]
        member _.IpConnectEnabled(state: BastionHostState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : BastionHostState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IpConnectEnabled <- value)
            state : BastionHostState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#kerberos_enabled-1">BastionHost#kerberos_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "kerberos_enabled">]
        member _.KerberosEnabled(state: BastionHostState<'Location, 'Name, 'ResourceGroupName>, value: bool) : BastionHostState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.KerberosEnabled <- value)
            state : BastionHostState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#kerberos_enabled-1">BastionHost#kerberos_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "kerberos_enabled">]
        member _.KerberosEnabled(state: BastionHostState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : BastionHostState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.KerberosEnabled <- value)
            state : BastionHostState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#scale_units-1">BastionHost#scale_units</a>.
        /// </summary>
        [<CustomOperation "scale_units">]
        member _.ScaleUnits(state: BastionHostState<'Location, 'Name, 'ResourceGroupName>, value: double) : BastionHostState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ScaleUnits <- value)
            state : BastionHostState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#shareable_link_enabled-1">BastionHost#shareable_link_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "shareable_link_enabled">]
        member _.ShareableLinkEnabled(state: BastionHostState<'Location, 'Name, 'ResourceGroupName>, value: bool) : BastionHostState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ShareableLinkEnabled <- value)
            state : BastionHostState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#shareable_link_enabled-1">BastionHost#shareable_link_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "shareable_link_enabled">]
        member _.ShareableLinkEnabled(state: BastionHostState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : BastionHostState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ShareableLinkEnabled <- value)
            state : BastionHostState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#sku-1">BastionHost#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: BastionHostState<'Location, 'Name, 'ResourceGroupName>, value: string) : BastionHostState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Sku <- value)
            state : BastionHostState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#tags-1">BastionHost#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BastionHostState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : BastionHostState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BastionHostState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#timeouts-1">BastionHost#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BastionHostState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.BastionHost.BastionHostTimeouts) : BastionHostState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BastionHostState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#tunneling_enabled-1">BastionHost#tunneling_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "tunneling_enabled">]
        member _.TunnelingEnabled(state: BastionHostState<'Location, 'Name, 'ResourceGroupName>, value: bool) : BastionHostState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TunnelingEnabled <- value)
            state : BastionHostState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#tunneling_enabled-1">BastionHost#tunneling_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "tunneling_enabled">]
        member _.TunnelingEnabled(state: BastionHostState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : BastionHostState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TunnelingEnabled <- value)
            state : BastionHostState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bastion_host#virtual_network_id-1">BastionHost#virtual_network_id</a>.
        /// </summary>
        [<CustomOperation "virtual_network_id">]
        member _.VirtualNetworkId(state: BastionHostState<'Location, 'Name, 'ResourceGroupName>, value: string) : BastionHostState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.VirtualNetworkId <- value)
            state : BastionHostState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: BastionHostState<Present, Present, Present>) : azurerm.BastionHost.BastionHost =
            let config = azurerm.BastionHost.BastionHostConfig()
            for setter in state.assignments do
                setter config
            azurerm.BastionHost.BastionHost(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.bastionHost: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: BastionHostState<_, _, _>) : azurerm.BastionHost.BastionHost =
            Unchecked.defaultof<azurerm.BastionHost.BastionHost>
