namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.SharedImage.SharedImageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image">azurerm_shared_image</a>.
    /// </summary>
    type SharedImageBuilder(logicalId: string) =
        member _.Yield(_: unit) : SharedImageState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SharedImageState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SharedImageState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SharedImageState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#gallery_name-1">SharedImage#gallery_name</a>.
        /// </summary>
        [<CustomOperation "gallery_name">]
        member _.GalleryName(state: SharedImageState<Missing, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: string) : SharedImageState<Present, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GalleryName <- value)
            ({ assignments = state.assignments } : SharedImageState<Present, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>)

        /// <summary>
        /// identifier block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#identifier-1">SharedImage#identifier</a>
        /// </summary>
        [<CustomOperation "identifier">]
        member _.Identifier(state: SharedImageState<'GalleryName, Missing, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: azurerm.SharedImage.SharedImageIdentifier) : SharedImageState<'GalleryName, Present, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identifier <- value)
            ({ assignments = state.assignments } : SharedImageState<'GalleryName, Present, 'Location, 'Name, 'OsType, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#location-1">SharedImage#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SharedImageState<'GalleryName, 'Identifier, Missing, 'Name, 'OsType, 'ResourceGroupName>, value: string) : SharedImageState<'GalleryName, 'Identifier, Present, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : SharedImageState<'GalleryName, 'Identifier, Present, 'Name, 'OsType, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#name-1">SharedImage#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SharedImageState<'GalleryName, 'Identifier, 'Location, Missing, 'OsType, 'ResourceGroupName>, value: string) : SharedImageState<'GalleryName, 'Identifier, 'Location, Present, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SharedImageState<'GalleryName, 'Identifier, 'Location, Present, 'OsType, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#os_type-1">SharedImage#os_type</a>.
        /// </summary>
        [<CustomOperation "os_type">]
        member _.OsType(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, Missing, 'ResourceGroupName>, value: string) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.OsType <- value)
            ({ assignments = state.assignments } : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#resource_group_name-1">SharedImage#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, Missing>, value: string) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#accelerated_network_support_enabled-1">SharedImage#accelerated_network_support_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "accelerated_network_support_enabled">]
        member _.AcceleratedNetworkSupportEnabled(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: bool) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AcceleratedNetworkSupportEnabled <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#accelerated_network_support_enabled-1">SharedImage#accelerated_network_support_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "accelerated_network_support_enabled">]
        member _.AcceleratedNetworkSupportEnabled(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AcceleratedNetworkSupportEnabled <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#architecture-1">SharedImage#architecture</a>.
        /// </summary>
        [<CustomOperation "architecture">]
        member _.Architecture(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: string) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Architecture <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#confidential_vm_enabled-1">SharedImage#confidential_vm_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "confidential_vm_enabled">]
        member _.ConfidentialVmEnabled(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: bool) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ConfidentialVmEnabled <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#confidential_vm_enabled-1">SharedImage#confidential_vm_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "confidential_vm_enabled">]
        member _.ConfidentialVmEnabled(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ConfidentialVmEnabled <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#confidential_vm_supported-1">SharedImage#confidential_vm_supported</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "confidential_vm_supported">]
        member _.ConfidentialVmSupported(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: bool) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ConfidentialVmSupported <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#confidential_vm_supported-1">SharedImage#confidential_vm_supported</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "confidential_vm_supported">]
        member _.ConfidentialVmSupported(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ConfidentialVmSupported <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#description-1">SharedImage#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: string) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#disk_types_not_allowed-1">SharedImage#disk_types_not_allowed</a>.
        /// </summary>
        [<CustomOperation "disk_types_not_allowed">]
        member _.DiskTypesNotAllowed(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: seq<string>) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DiskTypesNotAllowed <- (value |> Seq.toArray))
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#end_of_life_date-1">SharedImage#end_of_life_date</a>.
        /// </summary>
        [<CustomOperation "end_of_life_date">]
        member _.EndOfLifeDate(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: string) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EndOfLifeDate <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#eula-1">SharedImage#eula</a>.
        /// </summary>
        [<CustomOperation "eula">]
        member _.Eula(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: string) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Eula <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#hibernation_enabled-1">SharedImage#hibernation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "hibernation_enabled">]
        member _.HibernationEnabled(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: bool) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HibernationEnabled <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#hibernation_enabled-1">SharedImage#hibernation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "hibernation_enabled">]
        member _.HibernationEnabled(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HibernationEnabled <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#hyper_v_generation-1">SharedImage#hyper_v_generation</a>.
        /// </summary>
        [<CustomOperation "hyper_v_generation">]
        member _.HyperVGeneration(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: string) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HyperVGeneration <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#id-1">SharedImage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: string) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#max_recommended_memory_in_gb-1">SharedImage#max_recommended_memory_in_gb</a>.
        /// </summary>
        [<CustomOperation "max_recommended_memory_in_gb">]
        member _.MaxRecommendedMemoryInGb(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: double) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MaxRecommendedMemoryInGb <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#max_recommended_vcpu_count-1">SharedImage#max_recommended_vcpu_count</a>.
        /// </summary>
        [<CustomOperation "max_recommended_vcpu_count">]
        member _.MaxRecommendedVcpuCount(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: double) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MaxRecommendedVcpuCount <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#min_recommended_memory_in_gb-1">SharedImage#min_recommended_memory_in_gb</a>.
        /// </summary>
        [<CustomOperation "min_recommended_memory_in_gb">]
        member _.MinRecommendedMemoryInGb(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: double) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MinRecommendedMemoryInGb <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#min_recommended_vcpu_count-1">SharedImage#min_recommended_vcpu_count</a>.
        /// </summary>
        [<CustomOperation "min_recommended_vcpu_count">]
        member _.MinRecommendedVcpuCount(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: double) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MinRecommendedVcpuCount <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#privacy_statement_uri-1">SharedImage#privacy_statement_uri</a>.
        /// </summary>
        [<CustomOperation "privacy_statement_uri">]
        member _.PrivacyStatementUri(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: string) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PrivacyStatementUri <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// purchase_plan block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#purchase_plan-1">SharedImage#purchase_plan</a>
        /// </summary>
        [<CustomOperation "purchase_plan">]
        member _.PurchasePlan(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: azurerm.SharedImage.SharedImagePurchasePlan) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PurchasePlan <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#release_note_uri-1">SharedImage#release_note_uri</a>.
        /// </summary>
        [<CustomOperation "release_note_uri">]
        member _.ReleaseNoteUri(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: string) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ReleaseNoteUri <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#specialized-1">SharedImage#specialized</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "specialized">]
        member _.Specialized(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: bool) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Specialized <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#specialized-1">SharedImage#specialized</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "specialized">]
        member _.Specialized(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Specialized <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#tags-1">SharedImage#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: seq<string * string>) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#timeouts-1">SharedImage#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: azurerm.SharedImage.SharedImageTimeouts) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#trusted_launch_enabled-1">SharedImage#trusted_launch_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "trusted_launch_enabled">]
        member _.TrustedLaunchEnabled(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: bool) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TrustedLaunchEnabled <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#trusted_launch_enabled-1">SharedImage#trusted_launch_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "trusted_launch_enabled">]
        member _.TrustedLaunchEnabled(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TrustedLaunchEnabled <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#trusted_launch_supported-1">SharedImage#trusted_launch_supported</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "trusted_launch_supported">]
        member _.TrustedLaunchSupported(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: bool) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TrustedLaunchSupported <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#trusted_launch_supported-1">SharedImage#trusted_launch_supported</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "trusted_launch_supported">]
        member _.TrustedLaunchSupported(state: SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TrustedLaunchSupported <- value)
            state : SharedImageState<'GalleryName, 'Identifier, 'Location, 'Name, 'OsType, 'ResourceGroupName>

        member _.Run(state: SharedImageState<Present, Present, Present, Present, Present, Present>) : azurerm.SharedImage.SharedImage =
            let config = azurerm.SharedImage.SharedImageConfig()
            for setter in state.assignments do
                setter config
            azurerm.SharedImage.SharedImage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sharedImage: missing required arguments. Must call: gallery_name, identifier, location, name, os_type, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: SharedImageState<_, _, _, _, _, _>) : azurerm.SharedImage.SharedImage =
            Unchecked.defaultof<azurerm.SharedImage.SharedImage>
