namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ContainerGroup.ContainerGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group">azurerm_container_group</a>.
    /// </summary>
    type ContainerGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : ContainerGroupState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerGroupState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ContainerGroupState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerGroupState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// container block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#container-1">ContainerGroup#container</a> Accepts: azurerm.IResolvable | azurerm.ContainerGroup.ContainerGroupContainer[]
        /// </summary>
        [<CustomOperation "container">]
        member _.Container(state: ContainerGroupState<Missing, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ContainerGroupState<Present, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Container <- value)
            ({ assignments = state.assignments } : ContainerGroupState<Present, 'Location, 'Name, 'OsType, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#location-1">ContainerGroup#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ContainerGroupState<'Container, Missing, 'Name, 'OsType, 'ResourceGroupName>, value: string) : ContainerGroupState<'Container, Present, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ContainerGroupState<'Container, Present, 'Name, 'OsType, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#name-1">ContainerGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ContainerGroupState<'Container, 'Location, Missing, 'OsType, 'ResourceGroupName>, value: string) : ContainerGroupState<'Container, 'Location, Present, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ContainerGroupState<'Container, 'Location, Present, 'OsType, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#os_type-1">ContainerGroup#os_type</a>.
        /// </summary>
        [<CustomOperation "os_type">]
        member _.OsType(state: ContainerGroupState<'Container, 'Location, 'Name, Missing, 'ResourceGroupName>, value: string) : ContainerGroupState<'Container, 'Location, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.OsType <- value)
            ({ assignments = state.assignments } : ContainerGroupState<'Container, 'Location, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#resource_group_name-1">ContainerGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ContainerGroupState<'Container, 'Location, 'Name, 'OsType, Missing>, value: string) : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, Present>)

        /// <summary>
        /// diagnostics block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#diagnostics-1">ContainerGroup#diagnostics</a>
        /// </summary>
        [<CustomOperation "diagnostics">]
        member _.Diagnostics(state: ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: azurerm.ContainerGroup.ContainerGroupDiagnostics) : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Diagnostics <- value)
            state : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// dns_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#dns_config-1">ContainerGroup#dns_config</a>
        /// </summary>
        [<CustomOperation "dns_config">]
        member _.DnsConfig(state: ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: azurerm.ContainerGroup.ContainerGroupDnsConfig) : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DnsConfig <- value)
            state : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#dns_name_label-1">ContainerGroup#dns_name_label</a>.
        /// </summary>
        [<CustomOperation "dns_name_label">]
        member _.DnsNameLabel(state: ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: string) : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DnsNameLabel <- value)
            state : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#dns_name_label_reuse_policy-1">ContainerGroup#dns_name_label_reuse_policy</a>.
        /// </summary>
        [<CustomOperation "dns_name_label_reuse_policy">]
        member _.DnsNameLabelReusePolicy(state: ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: string) : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DnsNameLabelReusePolicy <- value)
            state : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#exposed_port-1">ContainerGroup#exposed_port</a>. Accepts: azurerm.IResolvable | azurerm.ContainerGroup.ContainerGroupExposedPort[]
        /// </summary>
        [<CustomOperation "exposed_port">]
        member _.ExposedPort(state: ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ExposedPort <- value)
            state : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#id-1">ContainerGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: string) : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#identity-1">ContainerGroup#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: azurerm.ContainerGroup.ContainerGroupIdentity) : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// image_registry_credential block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#image_registry_credential-1">ContainerGroup#image_registry_credential</a> Accepts: azurerm.IResolvable | azurerm.ContainerGroup.ContainerGroupImageRegistryCredential[]
        /// </summary>
        [<CustomOperation "image_registry_credential">]
        member _.ImageRegistryCredential(state: ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ImageRegistryCredential <- value)
            state : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// init_container block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#init_container-1">ContainerGroup#init_container</a> Accepts: azurerm.IResolvable | azurerm.ContainerGroup.ContainerGroupInitContainer[]
        /// </summary>
        [<CustomOperation "init_container">]
        member _.InitContainer(state: ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InitContainer <- value)
            state : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#ip_address_type-1">ContainerGroup#ip_address_type</a>.
        /// </summary>
        [<CustomOperation "ip_address_type">]
        member _.IpAddressType(state: ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: string) : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IpAddressType <- value)
            state : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#key_vault_key_id-1">ContainerGroup#key_vault_key_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_key_id">]
        member _.KeyVaultKeyId(state: ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: string) : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.KeyVaultKeyId <- value)
            state : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#key_vault_user_assigned_identity_id-1">ContainerGroup#key_vault_user_assigned_identity_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_user_assigned_identity_id">]
        member _.KeyVaultUserAssignedIdentityId(state: ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: string) : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.KeyVaultUserAssignedIdentityId <- value)
            state : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#network_profile_id-1">ContainerGroup#network_profile_id</a>.
        /// </summary>
        [<CustomOperation "network_profile_id">]
        member _.NetworkProfileId(state: ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: string) : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NetworkProfileId <- value)
            state : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#priority-1">ContainerGroup#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: string) : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Priority <- value)
            state : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#restart_policy-1">ContainerGroup#restart_policy</a>.
        /// </summary>
        [<CustomOperation "restart_policy">]
        member _.RestartPolicy(state: ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: string) : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RestartPolicy <- value)
            state : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#sku-1">ContainerGroup#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: string) : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Sku <- value)
            state : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#subnet_ids-1">ContainerGroup#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: seq<string>) : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            state : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#tags-1">ContainerGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: seq<string * string>) : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#timeouts-1">ContainerGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: azurerm.ContainerGroup.ContainerGroupTimeouts) : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#zones-1">ContainerGroup#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: seq<string>) : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            state : ContainerGroupState<'Container, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        member _.Run(state: ContainerGroupState<Present, Present, Present, Present, Present>) : azurerm.ContainerGroup.ContainerGroup =
            let config = azurerm.ContainerGroup.ContainerGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.ContainerGroup.ContainerGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.containerGroup: missing required arguments. Must call: container, location, name, os_type, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ContainerGroupState<_, _, _, _, _>) : azurerm.ContainerGroup.ContainerGroup =
            Unchecked.defaultof<azurerm.ContainerGroup.ContainerGroup>
