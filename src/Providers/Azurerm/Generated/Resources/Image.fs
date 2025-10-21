namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ImageState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.Image.ImageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/image">azurerm_image</a>.
    /// </summary>
    type ImageBuilder(logicalId: string) =
        member _.Yield(_: unit) : ImageState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ImageState<Missing, Missing, Missing>)

        member _.Zero(()) : ImageState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ImageState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/image#location-1">Image#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ImageState<Missing, 'Name, 'ResourceGroupName>, value: string) : ImageState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ImageState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/image#name-1">Image#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ImageState<'Location, Missing, 'ResourceGroupName>, value: string) : ImageState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ImageState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/image#resource_group_name-1">Image#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ImageState<'Location, 'Name, Missing>, value: string) : ImageState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ImageState<'Location, 'Name, Present>)

        /// <summary>
        /// data_disk block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/image#data_disk-1">Image#data_disk</a> Accepts: azurerm.IResolvable | azurerm.Image.ImageDataDisk[]
        /// </summary>
        [<CustomOperation "data_disk">]
        member _.DataDisk(state: ImageState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ImageState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DataDisk <- value)
            state : ImageState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/image#hyper_v_generation-1">Image#hyper_v_generation</a>.
        /// </summary>
        [<CustomOperation "hyper_v_generation">]
        member _.HyperVGeneration(state: ImageState<'Location, 'Name, 'ResourceGroupName>, value: string) : ImageState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HyperVGeneration <- value)
            state : ImageState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/image#id-1">Image#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ImageState<'Location, 'Name, 'ResourceGroupName>, value: string) : ImageState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ImageState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// os_disk block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/image#os_disk-1">Image#os_disk</a>
        /// </summary>
        [<CustomOperation "os_disk">]
        member _.OsDisk(state: ImageState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.Image.ImageOsDisk) : ImageState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.OsDisk <- value)
            state : ImageState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/image#source_virtual_machine_id-1">Image#source_virtual_machine_id</a>.
        /// </summary>
        [<CustomOperation "source_virtual_machine_id">]
        member _.SourceVirtualMachineId(state: ImageState<'Location, 'Name, 'ResourceGroupName>, value: string) : ImageState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SourceVirtualMachineId <- value)
            state : ImageState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/image#tags-1">Image#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ImageState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : ImageState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ImageState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/image#timeouts-1">Image#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ImageState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.Image.ImageTimeouts) : ImageState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ImageState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/image#zone_resilient-1">Image#zone_resilient</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_resilient">]
        member _.ZoneResilient(state: ImageState<'Location, 'Name, 'ResourceGroupName>, value: bool) : ImageState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ZoneResilient <- value)
            state : ImageState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/image#zone_resilient-1">Image#zone_resilient</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_resilient">]
        member _.ZoneResilient(state: ImageState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ImageState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ZoneResilient <- value)
            state : ImageState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: ImageState<Present, Present, Present>) : azurerm.Image.Image =
            let config = azurerm.Image.ImageConfig()
            for setter in state.assignments do
                setter config
            azurerm.Image.Image(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.image: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ImageState<_, _, _>) : azurerm.Image.Image =
            Unchecked.defaultof<azurerm.Image.Image>
