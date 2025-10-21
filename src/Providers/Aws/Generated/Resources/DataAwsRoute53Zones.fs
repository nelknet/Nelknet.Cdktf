namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRoute53ZonesState = { assignments: ResizeArray<aws.DataAwsRoute53Zones.DataAwsRoute53ZonesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_zones">aws_route53_zones</a>.
    /// </summary>
    type DataAwsRoute53ZonesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRoute53ZonesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsRoute53ZonesState =
            { assignments = ResizeArray() }



        member _.Run(state: DataAwsRoute53ZonesState) : aws.DataAwsRoute53Zones.DataAwsRoute53Zones =
            let config = aws.DataAwsRoute53Zones.DataAwsRoute53ZonesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRoute53Zones.DataAwsRoute53Zones(StackContext.get (), logicalId, config)
