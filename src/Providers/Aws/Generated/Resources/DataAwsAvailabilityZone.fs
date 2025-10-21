namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAvailabilityZoneState = { assignments: ResizeArray<aws.DataAwsAvailabilityZone.DataAwsAvailabilityZoneConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zone">aws_availability_zone</a>.
    /// </summary>
    type DataAwsAvailabilityZoneBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAvailabilityZoneState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsAvailabilityZoneState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zone#all_availability_zones-1">DataAwsAvailabilityZone#all_availability_zones</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "all_availability_zones">]
        member _.AllAvailabilityZones(state: DataAwsAvailabilityZoneState, value: bool) : DataAwsAvailabilityZoneState =
            state.assignments.Add(fun config -> config.AllAvailabilityZones <- value)
            state : DataAwsAvailabilityZoneState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zone#all_availability_zones-1">DataAwsAvailabilityZone#all_availability_zones</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "all_availability_zones">]
        member _.AllAvailabilityZones(state: DataAwsAvailabilityZoneState, value: HashiCorp.Cdktf.IResolvable) : DataAwsAvailabilityZoneState =
            state.assignments.Add(fun config -> config.AllAvailabilityZones <- value)
            state : DataAwsAvailabilityZoneState

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zone#filter-1">DataAwsAvailabilityZone#filter</a> Accepts: aws.IResolvable | aws.DataAwsAvailabilityZone.DataAwsAvailabilityZoneFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsAvailabilityZoneState, value: HashiCorp.Cdktf.IResolvable) : DataAwsAvailabilityZoneState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsAvailabilityZoneState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zone#id-1">DataAwsAvailabilityZone#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAvailabilityZoneState, value: string) : DataAwsAvailabilityZoneState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAvailabilityZoneState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zone#name-1">DataAwsAvailabilityZone#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsAvailabilityZoneState, value: string) : DataAwsAvailabilityZoneState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsAvailabilityZoneState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zone#state-1">DataAwsAvailabilityZone#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: DataAwsAvailabilityZoneState, value: string) : DataAwsAvailabilityZoneState =
            state.assignments.Add(fun config -> config.State <- value)
            state : DataAwsAvailabilityZoneState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zone#timeouts-1">DataAwsAvailabilityZone#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsAvailabilityZoneState, value: aws.DataAwsAvailabilityZone.DataAwsAvailabilityZoneTimeouts) : DataAwsAvailabilityZoneState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsAvailabilityZoneState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zone#zone_id-1">DataAwsAvailabilityZone#zone_id</a>.
        /// </summary>
        [<CustomOperation "zone_id">]
        member _.ZoneId(state: DataAwsAvailabilityZoneState, value: string) : DataAwsAvailabilityZoneState =
            state.assignments.Add(fun config -> config.ZoneId <- value)
            state : DataAwsAvailabilityZoneState

        member _.Run(state: DataAwsAvailabilityZoneState) : aws.DataAwsAvailabilityZone.DataAwsAvailabilityZone =
            let config = aws.DataAwsAvailabilityZone.DataAwsAvailabilityZoneConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAvailabilityZone.DataAwsAvailabilityZone(StackContext.get (), logicalId, config)
