namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DirectoryServiceRegionState<'DirectoryId, 'RegionName, 'VpcSettings> = { assignments: ResizeArray<aws.DirectoryServiceRegion.DirectoryServiceRegionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_region">aws_directory_service_region</a>.
    /// </summary>
    type DirectoryServiceRegionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DirectoryServiceRegionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DirectoryServiceRegionState<Missing, Missing, Missing>)

        member _.Zero(()) : DirectoryServiceRegionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DirectoryServiceRegionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_region#directory_id-1">DirectoryServiceRegion#directory_id</a>.
        /// </summary>
        [<CustomOperation "directory_id">]
        member _.DirectoryId(state: DirectoryServiceRegionState<Missing, 'RegionName, 'VpcSettings>, value: string) : DirectoryServiceRegionState<Present, 'RegionName, 'VpcSettings> =
            state.assignments.Add(fun config -> config.DirectoryId <- value)
            ({ assignments = state.assignments } : DirectoryServiceRegionState<Present, 'RegionName, 'VpcSettings>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_region#region_name-1">DirectoryServiceRegion#region_name</a>.
        /// </summary>
        [<CustomOperation "region_name">]
        member _.RegionName(state: DirectoryServiceRegionState<'DirectoryId, Missing, 'VpcSettings>, value: string) : DirectoryServiceRegionState<'DirectoryId, Present, 'VpcSettings> =
            state.assignments.Add(fun config -> config.RegionName <- value)
            ({ assignments = state.assignments } : DirectoryServiceRegionState<'DirectoryId, Present, 'VpcSettings>)

        /// <summary>
        /// vpc_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_region#vpc_settings-1">DirectoryServiceRegion#vpc_settings</a>
        /// </summary>
        [<CustomOperation "vpc_settings">]
        member _.VpcSettings(state: DirectoryServiceRegionState<'DirectoryId, 'RegionName, Missing>, value: aws.DirectoryServiceRegion.DirectoryServiceRegionVpcSettings) : DirectoryServiceRegionState<'DirectoryId, 'RegionName, Present> =
            state.assignments.Add(fun config -> config.VpcSettings <- value)
            ({ assignments = state.assignments } : DirectoryServiceRegionState<'DirectoryId, 'RegionName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_region#desired_number_of_domain_controllers-1">DirectoryServiceRegion#desired_number_of_domain_controllers</a>.
        /// </summary>
        [<CustomOperation "desired_number_of_domain_controllers">]
        member _.DesiredNumberOfDomainControllers(state: DirectoryServiceRegionState<'DirectoryId, 'RegionName, 'VpcSettings>, value: double) : DirectoryServiceRegionState<'DirectoryId, 'RegionName, 'VpcSettings> =
            state.assignments.Add(fun config -> config.DesiredNumberOfDomainControllers <- value)
            state : DirectoryServiceRegionState<'DirectoryId, 'RegionName, 'VpcSettings>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_region#id-1">DirectoryServiceRegion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DirectoryServiceRegionState<'DirectoryId, 'RegionName, 'VpcSettings>, value: string) : DirectoryServiceRegionState<'DirectoryId, 'RegionName, 'VpcSettings> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DirectoryServiceRegionState<'DirectoryId, 'RegionName, 'VpcSettings>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_region#tags-1">DirectoryServiceRegion#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DirectoryServiceRegionState<'DirectoryId, 'RegionName, 'VpcSettings>, value: seq<string * string>) : DirectoryServiceRegionState<'DirectoryId, 'RegionName, 'VpcSettings> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DirectoryServiceRegionState<'DirectoryId, 'RegionName, 'VpcSettings>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_region#tags_all-1">DirectoryServiceRegion#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DirectoryServiceRegionState<'DirectoryId, 'RegionName, 'VpcSettings>, value: seq<string * string>) : DirectoryServiceRegionState<'DirectoryId, 'RegionName, 'VpcSettings> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DirectoryServiceRegionState<'DirectoryId, 'RegionName, 'VpcSettings>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_region#timeouts-1">DirectoryServiceRegion#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DirectoryServiceRegionState<'DirectoryId, 'RegionName, 'VpcSettings>, value: aws.DirectoryServiceRegion.DirectoryServiceRegionTimeouts) : DirectoryServiceRegionState<'DirectoryId, 'RegionName, 'VpcSettings> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DirectoryServiceRegionState<'DirectoryId, 'RegionName, 'VpcSettings>

        member _.Run(state: DirectoryServiceRegionState<Present, Present, Present>) : aws.DirectoryServiceRegion.DirectoryServiceRegion =
            let config = aws.DirectoryServiceRegion.DirectoryServiceRegionConfig()
            for setter in state.assignments do
                setter config
            aws.DirectoryServiceRegion.DirectoryServiceRegion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.directoryServiceRegion: missing required arguments. Must call: directory_id, region_name, vpc_settings.", 9999, IsError = true)>]
        member _.Run(_: DirectoryServiceRegionState<_, _, _>) : aws.DirectoryServiceRegion.DirectoryServiceRegion =
            Unchecked.defaultof<aws.DirectoryServiceRegion.DirectoryServiceRegion>
