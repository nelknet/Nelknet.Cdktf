namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAvailabilityZonesState = { assignments: ResizeArray<aws.DataAwsAvailabilityZones.DataAwsAvailabilityZonesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zones">aws_availability_zones</a>.
    /// </summary>
    type DataAwsAvailabilityZonesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAvailabilityZonesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsAvailabilityZonesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zones#all_availability_zones-1">DataAwsAvailabilityZones#all_availability_zones</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "all_availability_zones">]
        member _.AllAvailabilityZones(state: DataAwsAvailabilityZonesState, value: bool) : DataAwsAvailabilityZonesState =
            state.assignments.Add(fun config -> config.AllAvailabilityZones <- value)
            state : DataAwsAvailabilityZonesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zones#all_availability_zones-1">DataAwsAvailabilityZones#all_availability_zones</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "all_availability_zones">]
        member _.AllAvailabilityZones(state: DataAwsAvailabilityZonesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsAvailabilityZonesState =
            state.assignments.Add(fun config -> config.AllAvailabilityZones <- value)
            state : DataAwsAvailabilityZonesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zones#exclude_names-1">DataAwsAvailabilityZones#exclude_names</a>.
        /// </summary>
        [<CustomOperation "exclude_names">]
        member _.ExcludeNames(state: DataAwsAvailabilityZonesState, value: seq<string>) : DataAwsAvailabilityZonesState =
            state.assignments.Add(fun config -> config.ExcludeNames <- (value |> Seq.toArray))
            state : DataAwsAvailabilityZonesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zones#exclude_zone_ids-1">DataAwsAvailabilityZones#exclude_zone_ids</a>.
        /// </summary>
        [<CustomOperation "exclude_zone_ids">]
        member _.ExcludeZoneIds(state: DataAwsAvailabilityZonesState, value: seq<string>) : DataAwsAvailabilityZonesState =
            state.assignments.Add(fun config -> config.ExcludeZoneIds <- (value |> Seq.toArray))
            state : DataAwsAvailabilityZonesState

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zones#filter-1">DataAwsAvailabilityZones#filter</a> Accepts: aws.IResolvable | aws.DataAwsAvailabilityZones.DataAwsAvailabilityZonesFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsAvailabilityZonesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsAvailabilityZonesState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsAvailabilityZonesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zones#id-1">DataAwsAvailabilityZones#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAvailabilityZonesState, value: string) : DataAwsAvailabilityZonesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAvailabilityZonesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zones#state-1">DataAwsAvailabilityZones#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: DataAwsAvailabilityZonesState, value: string) : DataAwsAvailabilityZonesState =
            state.assignments.Add(fun config -> config.State <- value)
            state : DataAwsAvailabilityZonesState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zones#timeouts-1">DataAwsAvailabilityZones#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsAvailabilityZonesState, value: aws.DataAwsAvailabilityZones.DataAwsAvailabilityZonesTimeouts) : DataAwsAvailabilityZonesState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsAvailabilityZonesState

        member _.Run(state: DataAwsAvailabilityZonesState) : aws.DataAwsAvailabilityZones.DataAwsAvailabilityZones =
            let config = aws.DataAwsAvailabilityZones.DataAwsAvailabilityZonesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAvailabilityZones.DataAwsAvailabilityZones(StackContext.get (), logicalId, config)
