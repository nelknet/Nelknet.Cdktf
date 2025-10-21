namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevCenterDevBoxDefinitionState<'DevCenterId, 'ImageReferenceId, 'Location, 'Name, 'SkuName> = { assignments: ResizeArray<azurerm.DevCenterDevBoxDefinition.DevCenterDevBoxDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_dev_box_definition">azurerm_dev_center_dev_box_definition</a>.
    /// </summary>
    type DevCenterDevBoxDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevCenterDevBoxDefinitionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevCenterDevBoxDefinitionState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DevCenterDevBoxDefinitionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevCenterDevBoxDefinitionState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_dev_box_definition#dev_center_id-1">DevCenterDevBoxDefinition#dev_center_id</a>.
        /// </summary>
        [<CustomOperation "dev_center_id">]
        member _.DevCenterId(state: DevCenterDevBoxDefinitionState<Missing, 'ImageReferenceId, 'Location, 'Name, 'SkuName>, value: string) : DevCenterDevBoxDefinitionState<Present, 'ImageReferenceId, 'Location, 'Name, 'SkuName> =
            state.assignments.Add(fun config -> config.DevCenterId <- value)
            ({ assignments = state.assignments } : DevCenterDevBoxDefinitionState<Present, 'ImageReferenceId, 'Location, 'Name, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_dev_box_definition#image_reference_id-1">DevCenterDevBoxDefinition#image_reference_id</a>.
        /// </summary>
        [<CustomOperation "image_reference_id">]
        member _.ImageReferenceId(state: DevCenterDevBoxDefinitionState<'DevCenterId, Missing, 'Location, 'Name, 'SkuName>, value: string) : DevCenterDevBoxDefinitionState<'DevCenterId, Present, 'Location, 'Name, 'SkuName> =
            state.assignments.Add(fun config -> config.ImageReferenceId <- value)
            ({ assignments = state.assignments } : DevCenterDevBoxDefinitionState<'DevCenterId, Present, 'Location, 'Name, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_dev_box_definition#location-1">DevCenterDevBoxDefinition#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DevCenterDevBoxDefinitionState<'DevCenterId, 'ImageReferenceId, Missing, 'Name, 'SkuName>, value: string) : DevCenterDevBoxDefinitionState<'DevCenterId, 'ImageReferenceId, Present, 'Name, 'SkuName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DevCenterDevBoxDefinitionState<'DevCenterId, 'ImageReferenceId, Present, 'Name, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_dev_box_definition#name-1">DevCenterDevBoxDefinition#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DevCenterDevBoxDefinitionState<'DevCenterId, 'ImageReferenceId, 'Location, Missing, 'SkuName>, value: string) : DevCenterDevBoxDefinitionState<'DevCenterId, 'ImageReferenceId, 'Location, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DevCenterDevBoxDefinitionState<'DevCenterId, 'ImageReferenceId, 'Location, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_dev_box_definition#sku_name-1">DevCenterDevBoxDefinition#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: DevCenterDevBoxDefinitionState<'DevCenterId, 'ImageReferenceId, 'Location, 'Name, Missing>, value: string) : DevCenterDevBoxDefinitionState<'DevCenterId, 'ImageReferenceId, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : DevCenterDevBoxDefinitionState<'DevCenterId, 'ImageReferenceId, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_dev_box_definition#id-1">DevCenterDevBoxDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DevCenterDevBoxDefinitionState<'DevCenterId, 'ImageReferenceId, 'Location, 'Name, 'SkuName>, value: string) : DevCenterDevBoxDefinitionState<'DevCenterId, 'ImageReferenceId, 'Location, 'Name, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DevCenterDevBoxDefinitionState<'DevCenterId, 'ImageReferenceId, 'Location, 'Name, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_dev_box_definition#tags-1">DevCenterDevBoxDefinition#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DevCenterDevBoxDefinitionState<'DevCenterId, 'ImageReferenceId, 'Location, 'Name, 'SkuName>, value: seq<string * string>) : DevCenterDevBoxDefinitionState<'DevCenterId, 'ImageReferenceId, 'Location, 'Name, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DevCenterDevBoxDefinitionState<'DevCenterId, 'ImageReferenceId, 'Location, 'Name, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_dev_box_definition#timeouts-1">DevCenterDevBoxDefinition#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DevCenterDevBoxDefinitionState<'DevCenterId, 'ImageReferenceId, 'Location, 'Name, 'SkuName>, value: azurerm.DevCenterDevBoxDefinition.DevCenterDevBoxDefinitionTimeouts) : DevCenterDevBoxDefinitionState<'DevCenterId, 'ImageReferenceId, 'Location, 'Name, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DevCenterDevBoxDefinitionState<'DevCenterId, 'ImageReferenceId, 'Location, 'Name, 'SkuName>

        member _.Run(state: DevCenterDevBoxDefinitionState<Present, Present, Present, Present, Present>) : azurerm.DevCenterDevBoxDefinition.DevCenterDevBoxDefinition =
            let config = azurerm.DevCenterDevBoxDefinition.DevCenterDevBoxDefinitionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DevCenterDevBoxDefinition.DevCenterDevBoxDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.devCenterDevBoxDefinition: missing required arguments. Must call: dev_center_id, image_reference_id, location, name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: DevCenterDevBoxDefinitionState<_, _, _, _, _>) : azurerm.DevCenterDevBoxDefinition.DevCenterDevBoxDefinition =
            Unchecked.defaultof<azurerm.DevCenterDevBoxDefinition.DevCenterDevBoxDefinition>
