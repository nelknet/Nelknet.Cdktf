namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOutpostsOutpostsState = { assignments: ResizeArray<aws.DataAwsOutpostsOutposts.DataAwsOutpostsOutpostsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_outposts">aws_outposts_outposts</a>.
    /// </summary>
    type DataAwsOutpostsOutpostsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOutpostsOutpostsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsOutpostsOutpostsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_outposts#availability_zone-1">DataAwsOutpostsOutposts#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: DataAwsOutpostsOutpostsState, value: string) : DataAwsOutpostsOutpostsState =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            state : DataAwsOutpostsOutpostsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_outposts#availability_zone_id-1">DataAwsOutpostsOutposts#availability_zone_id</a>.
        /// </summary>
        [<CustomOperation "availability_zone_id">]
        member _.AvailabilityZoneId(state: DataAwsOutpostsOutpostsState, value: string) : DataAwsOutpostsOutpostsState =
            state.assignments.Add(fun config -> config.AvailabilityZoneId <- value)
            state : DataAwsOutpostsOutpostsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_outposts#id-1">DataAwsOutpostsOutposts#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOutpostsOutpostsState, value: string) : DataAwsOutpostsOutpostsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOutpostsOutpostsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_outposts#owner_id-1">DataAwsOutpostsOutposts#owner_id</a>.
        /// </summary>
        [<CustomOperation "owner_id">]
        member _.OwnerId(state: DataAwsOutpostsOutpostsState, value: string) : DataAwsOutpostsOutpostsState =
            state.assignments.Add(fun config -> config.OwnerId <- value)
            state : DataAwsOutpostsOutpostsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_outposts#site_id-1">DataAwsOutpostsOutposts#site_id</a>.
        /// </summary>
        [<CustomOperation "site_id">]
        member _.SiteId(state: DataAwsOutpostsOutpostsState, value: string) : DataAwsOutpostsOutpostsState =
            state.assignments.Add(fun config -> config.SiteId <- value)
            state : DataAwsOutpostsOutpostsState

        member _.Run(state: DataAwsOutpostsOutpostsState) : aws.DataAwsOutpostsOutposts.DataAwsOutpostsOutposts =
            let config = aws.DataAwsOutpostsOutposts.DataAwsOutpostsOutpostsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOutpostsOutposts.DataAwsOutpostsOutposts(StackContext.get (), logicalId, config)
