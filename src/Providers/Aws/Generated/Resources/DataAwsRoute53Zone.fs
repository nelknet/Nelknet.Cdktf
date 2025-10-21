namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRoute53ZoneState = { assignments: ResizeArray<aws.DataAwsRoute53Zone.DataAwsRoute53ZoneConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_zone">aws_route53_zone</a>.
    /// </summary>
    type DataAwsRoute53ZoneBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRoute53ZoneState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsRoute53ZoneState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_zone#id-1">DataAwsRoute53Zone#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRoute53ZoneState, value: string) : DataAwsRoute53ZoneState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRoute53ZoneState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_zone#name-1">DataAwsRoute53Zone#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsRoute53ZoneState, value: string) : DataAwsRoute53ZoneState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsRoute53ZoneState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_zone#private_zone-1">DataAwsRoute53Zone#private_zone</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "private_zone">]
        member _.PrivateZone(state: DataAwsRoute53ZoneState, value: bool) : DataAwsRoute53ZoneState =
            state.assignments.Add(fun config -> config.PrivateZone <- value)
            state : DataAwsRoute53ZoneState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_zone#private_zone-1">DataAwsRoute53Zone#private_zone</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "private_zone">]
        member _.PrivateZone(state: DataAwsRoute53ZoneState, value: HashiCorp.Cdktf.IResolvable) : DataAwsRoute53ZoneState =
            state.assignments.Add(fun config -> config.PrivateZone <- value)
            state : DataAwsRoute53ZoneState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_zone#tags-1">DataAwsRoute53Zone#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsRoute53ZoneState, value: seq<string * string>) : DataAwsRoute53ZoneState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsRoute53ZoneState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_zone#vpc_id-1">DataAwsRoute53Zone#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: DataAwsRoute53ZoneState, value: string) : DataAwsRoute53ZoneState =
            state.assignments.Add(fun config -> config.VpcId <- value)
            state : DataAwsRoute53ZoneState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_zone#zone_id-1">DataAwsRoute53Zone#zone_id</a>.
        /// </summary>
        [<CustomOperation "zone_id">]
        member _.ZoneId(state: DataAwsRoute53ZoneState, value: string) : DataAwsRoute53ZoneState =
            state.assignments.Add(fun config -> config.ZoneId <- value)
            state : DataAwsRoute53ZoneState

        member _.Run(state: DataAwsRoute53ZoneState) : aws.DataAwsRoute53Zone.DataAwsRoute53Zone =
            let config = aws.DataAwsRoute53Zone.DataAwsRoute53ZoneConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRoute53Zone.DataAwsRoute53Zone(StackContext.get (), logicalId, config)
