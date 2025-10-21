namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username> = { assignments: ResizeArray<azurerm.DevTestWindowsVirtualMachine.DevTestWindowsVirtualMachineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_windows_virtual_machine">azurerm_dev_test_windows_virtual_machine</a>.
    /// </summary>
    type DevTestWindowsVirtualMachineBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevTestWindowsVirtualMachineState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevTestWindowsVirtualMachineState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DevTestWindowsVirtualMachineState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevTestWindowsVirtualMachineState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// gallery_image_reference block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_windows_virtual_machine#gallery_image_reference-1">DevTestWindowsVirtualMachine#gallery_image_reference</a>
        /// </summary>
        [<CustomOperation "gallery_image_reference">]
        member _.GalleryImageReference(state: DevTestWindowsVirtualMachineState<Missing, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: azurerm.DevTestWindowsVirtualMachine.DevTestWindowsVirtualMachineGalleryImageReference) : DevTestWindowsVirtualMachineState<Present, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.GalleryImageReference <- value)
            ({ assignments = state.assignments } : DevTestWindowsVirtualMachineState<Present, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_windows_virtual_machine#lab_name-1">DevTestWindowsVirtualMachine#lab_name</a>.
        /// </summary>
        [<CustomOperation "lab_name">]
        member _.LabName(state: DevTestWindowsVirtualMachineState<'GalleryImageReference, Missing, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: string) : DevTestWindowsVirtualMachineState<'GalleryImageReference, Present, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.LabName <- value)
            ({ assignments = state.assignments } : DevTestWindowsVirtualMachineState<'GalleryImageReference, Present, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_windows_virtual_machine#lab_subnet_name-1">DevTestWindowsVirtualMachine#lab_subnet_name</a>.
        /// </summary>
        [<CustomOperation "lab_subnet_name">]
        member _.LabSubnetName(state: DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, Missing, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: string) : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, Present, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.LabSubnetName <- value)
            ({ assignments = state.assignments } : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, Present, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_windows_virtual_machine#lab_virtual_network_id-1">DevTestWindowsVirtualMachine#lab_virtual_network_id</a>.
        /// </summary>
        [<CustomOperation "lab_virtual_network_id">]
        member _.LabVirtualNetworkId(state: DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, Missing, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: string) : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, Present, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.LabVirtualNetworkId <- value)
            ({ assignments = state.assignments } : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, Present, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_windows_virtual_machine#location-1">DevTestWindowsVirtualMachine#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, Missing, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: string) : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, Present, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, Present, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_windows_virtual_machine#name-1">DevTestWindowsVirtualMachine#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, Missing, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: string) : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, Present, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, Present, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_windows_virtual_machine#password-1">DevTestWindowsVirtualMachine#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, Missing, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: string) : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, Present, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.Password <- value)
            ({ assignments = state.assignments } : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, Present, 'ResourceGroupName, 'Size, 'StorageType, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_windows_virtual_machine#resource_group_name-1">DevTestWindowsVirtualMachine#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, Missing, 'Size, 'StorageType, 'Username>, value: string) : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, Present, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, Present, 'Size, 'StorageType, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_windows_virtual_machine#size-1">DevTestWindowsVirtualMachine#size</a>.
        /// </summary>
        [<CustomOperation "size">]
        member _.Size(state: DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, Missing, 'StorageType, 'Username>, value: string) : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, Present, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.Size <- value)
            ({ assignments = state.assignments } : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, Present, 'StorageType, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_windows_virtual_machine#storage_type-1">DevTestWindowsVirtualMachine#storage_type</a>.
        /// </summary>
        [<CustomOperation "storage_type">]
        member _.StorageType(state: DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, Missing, 'Username>, value: string) : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, Present, 'Username> =
            state.assignments.Add(fun config -> config.StorageType <- value)
            ({ assignments = state.assignments } : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, Present, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_windows_virtual_machine#username-1">DevTestWindowsVirtualMachine#username</a>.
        /// </summary>
        [<CustomOperation "username">]
        member _.Username(state: DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, Missing>, value: string) : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, Present> =
            state.assignments.Add(fun config -> config.Username <- value)
            ({ assignments = state.assignments } : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_windows_virtual_machine#allow_claim-1">DevTestWindowsVirtualMachine#allow_claim</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_claim">]
        member _.AllowClaim(state: DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: bool) : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.AllowClaim <- value)
            state : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_windows_virtual_machine#allow_claim-1">DevTestWindowsVirtualMachine#allow_claim</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_claim">]
        member _.AllowClaim(state: DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: HashiCorp.Cdktf.IResolvable) : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.AllowClaim <- value)
            state : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_windows_virtual_machine#disallow_public_ip_address-1">DevTestWindowsVirtualMachine#disallow_public_ip_address</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "disallow_public_ip_address">]
        member _.DisallowPublicIpAddress(state: DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: bool) : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.DisallowPublicIpAddress <- value)
            state : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_windows_virtual_machine#disallow_public_ip_address-1">DevTestWindowsVirtualMachine#disallow_public_ip_address</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "disallow_public_ip_address">]
        member _.DisallowPublicIpAddress(state: DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: HashiCorp.Cdktf.IResolvable) : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.DisallowPublicIpAddress <- value)
            state : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_windows_virtual_machine#id-1">DevTestWindowsVirtualMachine#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: string) : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>

        /// <summary>
        /// inbound_nat_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_windows_virtual_machine#inbound_nat_rule-1">DevTestWindowsVirtualMachine#inbound_nat_rule</a> Accepts: azurerm.IResolvable | azurerm.DevTestWindowsVirtualMachine.DevTestWindowsVirtualMachineInboundNatRule[]
        /// </summary>
        [<CustomOperation "inbound_nat_rule">]
        member _.InboundNatRule(state: DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: HashiCorp.Cdktf.IResolvable) : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.InboundNatRule <- value)
            state : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_windows_virtual_machine#notes-1">DevTestWindowsVirtualMachine#notes</a>.
        /// </summary>
        [<CustomOperation "notes">]
        member _.Notes(state: DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: string) : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.Notes <- value)
            state : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_windows_virtual_machine#tags-1">DevTestWindowsVirtualMachine#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: seq<string * string>) : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_windows_virtual_machine#timeouts-1">DevTestWindowsVirtualMachine#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>, value: azurerm.DevTestWindowsVirtualMachine.DevTestWindowsVirtualMachineTimeouts) : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DevTestWindowsVirtualMachineState<'GalleryImageReference, 'LabName, 'LabSubnetName, 'LabVirtualNetworkId, 'Location, 'Name, 'Password, 'ResourceGroupName, 'Size, 'StorageType, 'Username>

        member _.Run(state: DevTestWindowsVirtualMachineState<Present, Present, Present, Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.DevTestWindowsVirtualMachine.DevTestWindowsVirtualMachine =
            let config = azurerm.DevTestWindowsVirtualMachine.DevTestWindowsVirtualMachineConfig()
            for setter in state.assignments do
                setter config
            azurerm.DevTestWindowsVirtualMachine.DevTestWindowsVirtualMachine(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.devTestWindowsVirtualMachine: missing required arguments. Must call: gallery_image_reference, lab_name, lab_subnet_name, lab_virtual_network_id, location, name, password, resource_group_name, size, storage_type, username.", 9999, IsError = true)>]
        member _.Run(_: DevTestWindowsVirtualMachineState<_, _, _, _, _, _, _, _, _, _, _>) : azurerm.DevTestWindowsVirtualMachine.DevTestWindowsVirtualMachine =
            Unchecked.defaultof<azurerm.DevTestWindowsVirtualMachine.DevTestWindowsVirtualMachine>
