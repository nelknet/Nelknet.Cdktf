namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username> = { assignments: ResizeArray<azurerm.DevTestLinuxVirtualMachine.DevTestLinuxVirtualMachineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine">azurerm_dev_test_linux_virtual_machine</a>.
    /// </summary>
    type DevTestLinuxVirtualMachineBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevTestLinuxVirtualMachineState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevTestLinuxVirtualMachineState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DevTestLinuxVirtualMachineState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevTestLinuxVirtualMachineState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// gallery_image_reference block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine#gallery_image_reference-1">DevTestLinuxVirtualMachine#gallery_image_reference</a>
        /// </summary>
        [<CustomOperation "gallery_image_reference">]
        member _.GalleryImageReference(state: DevTestLinuxVirtualMachineState<Missing, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: azurerm.DevTestLinuxVirtualMachine.DevTestLinuxVirtualMachineGalleryImageReference) : DevTestLinuxVirtualMachineState<Present, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.GalleryImageReference <- value)
            ({ assignments = state.assignments } : DevTestLinuxVirtualMachineState<Present, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine#lab_name-1">DevTestLinuxVirtualMachine#lab_name</a>.
        /// </summary>
        [<CustomOperation "lab_name">]
        member _.LabName(state: DevTestLinuxVirtualMachineState<'GalleryImageReference, Missing, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: string) : DevTestLinuxVirtualMachineState<'GalleryImageReference, Present, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.LabName <- value)
            ({ assignments = state.assignments } : DevTestLinuxVirtualMachineState<'GalleryImageReference, Present, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine#lab_subnet_name-1">DevTestLinuxVirtualMachine#lab_subnet_name</a>.
        /// </summary>
        [<CustomOperation "lab_subnet_name">]
        member _.LabSubnetName(state: DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, Missing, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: string) : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, Present, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.LabSubnetName <- value)
            ({ assignments = state.assignments } : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, Present, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine#lab_virtual_network_id-1">DevTestLinuxVirtualMachine#lab_virtual_network_id</a>.
        /// </summary>
        [<CustomOperation "lab_virtual_network_id">]
        member _.LabVirtualNetworkId(state: DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, Missing, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: string) : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, Present, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.LabVirtualNetworkId <- value)
            ({ assignments = state.assignments } : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, Present, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine#location-1">DevTestLinuxVirtualMachine#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, Missing, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: string) : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, Present, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, Present, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine#name-1">DevTestLinuxVirtualMachine#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, Missing, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: string) : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, Present, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, Present, 'ResourceGroupName, 'Size, 'StorageType, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine#resource_group_name-1">DevTestLinuxVirtualMachine#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, Missing, 'Size, 'StorageType, 'Username>, value: string) : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, Present, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, Present, 'Size, 'StorageType, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine#size-1">DevTestLinuxVirtualMachine#size</a>.
        /// </summary>
        [<CustomOperation "size">]
        member _.Size(state: DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, Missing, 'StorageType, 'Username>, value: string) : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, Present, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.Size <- value)
            ({ assignments = state.assignments } : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, Present, 'StorageType, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine#storage_type-1">DevTestLinuxVirtualMachine#storage_type</a>.
        /// </summary>
        [<CustomOperation "storage_type">]
        member _.StorageType(state: DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, Missing, 'Username>, value: string) : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, Present, 'Username> =
            state.assignments.Add(fun config -> config.StorageType <- value)
            ({ assignments = state.assignments } : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, Present, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine#username-1">DevTestLinuxVirtualMachine#username</a>.
        /// </summary>
        [<CustomOperation "username">]
        member _.Username(state: DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, Missing>, value: string) : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, Present> =
            state.assignments.Add(fun config -> config.Username <- value)
            ({ assignments = state.assignments } : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine#allow_claim-1">DevTestLinuxVirtualMachine#allow_claim</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_claim">]
        member _.AllowClaim(state: DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: bool) : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.AllowClaim <- value)
            state : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine#allow_claim-1">DevTestLinuxVirtualMachine#allow_claim</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_claim">]
        member _.AllowClaim(state: DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: HashiCorp.Cdktf.IResolvable) : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.AllowClaim <- value)
            state : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine#disallow_public_ip_address-1">DevTestLinuxVirtualMachine#disallow_public_ip_address</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "disallow_public_ip_address">]
        member _.DisallowPublicIpAddress(state: DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: bool) : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.DisallowPublicIpAddress <- value)
            state : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine#disallow_public_ip_address-1">DevTestLinuxVirtualMachine#disallow_public_ip_address</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "disallow_public_ip_address">]
        member _.DisallowPublicIpAddress(state: DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: HashiCorp.Cdktf.IResolvable) : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.DisallowPublicIpAddress <- value)
            state : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine#id-1">DevTestLinuxVirtualMachine#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: string) : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>

        /// <summary>
        /// inbound_nat_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine#inbound_nat_rule-1">DevTestLinuxVirtualMachine#inbound_nat_rule</a> Accepts: azurerm.IResolvable | azurerm.DevTestLinuxVirtualMachine.DevTestLinuxVirtualMachineInboundNatRule[]
        /// </summary>
        [<CustomOperation "inbound_nat_rule">]
        member _.InboundNatRule(state: DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: HashiCorp.Cdktf.IResolvable) : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.InboundNatRule <- value)
            state : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine#notes-1">DevTestLinuxVirtualMachine#notes</a>.
        /// </summary>
        [<CustomOperation "notes">]
        member _.Notes(state: DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: string) : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.Notes <- value)
            state : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine#password-1">DevTestLinuxVirtualMachine#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: string) : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.Password <- value)
            state : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine#ssh_key-1">DevTestLinuxVirtualMachine#ssh_key</a>.
        /// </summary>
        [<CustomOperation "ssh_key">]
        member _.SshKey(state: DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: string) : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.SshKey <- value)
            state : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine#tags-1">DevTestLinuxVirtualMachine#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: seq<string * string>) : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_linux_virtual_machine#timeouts-1">DevTestLinuxVirtualMachine#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: azurerm.DevTestLinuxVirtualMachine.DevTestLinuxVirtualMachineTimeouts) : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DevTestLinuxVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'ResourceGroupName, 'Size, 'StorageType, 'Username>

        member _.Run(state: DevTestLinuxVirtualMachineState<Present, Present, Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.DevTestLinuxVirtualMachine.DevTestLinuxVirtualMachine =
            let config = azurerm.DevTestLinuxVirtualMachine.DevTestLinuxVirtualMachineConfig()
            for setter in state.assignments do
                setter config
            azurerm.DevTestLinuxVirtualMachine.DevTestLinuxVirtualMachine(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.devTestLinuxVirtualMachine: missing required arguments. Must call: gallery_image_reference, lab_name, lab_subnet_name, lab_virtual_network_id, location, name, resource_group_name, size, storage_type, username.", 9999, IsError = true)>]
        member _.Run(_: DevTestLinuxVirtualMachineState<_, _, _, _, _, _, _, _, _, _>) : azurerm.DevTestLinuxVirtualMachine.DevTestLinuxVirtualMachine =
            Unchecked.defaultof<azurerm.DevTestLinuxVirtualMachine.DevTestLinuxVirtualMachine>
