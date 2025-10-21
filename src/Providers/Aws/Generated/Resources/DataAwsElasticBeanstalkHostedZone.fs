namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsElasticBeanstalkHostedZoneState = { assignments: ResizeArray<aws.DataAwsElasticBeanstalkHostedZone.DataAwsElasticBeanstalkHostedZoneConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elastic_beanstalk_hosted_zone">aws_elastic_beanstalk_hosted_zone</a>.
    /// </summary>
    type DataAwsElasticBeanstalkHostedZoneBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsElasticBeanstalkHostedZoneState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsElasticBeanstalkHostedZoneState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elastic_beanstalk_hosted_zone#id-1">DataAwsElasticBeanstalkHostedZone#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsElasticBeanstalkHostedZoneState, value: string) : DataAwsElasticBeanstalkHostedZoneState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsElasticBeanstalkHostedZoneState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elastic_beanstalk_hosted_zone#region-1">DataAwsElasticBeanstalkHostedZone#region</a>.
        /// </summary>
        [<CustomOperation "region">]
        member _.Region(state: DataAwsElasticBeanstalkHostedZoneState, value: string) : DataAwsElasticBeanstalkHostedZoneState =
            state.assignments.Add(fun config -> config.Region <- value)
            state : DataAwsElasticBeanstalkHostedZoneState

        member _.Run(state: DataAwsElasticBeanstalkHostedZoneState) : aws.DataAwsElasticBeanstalkHostedZone.DataAwsElasticBeanstalkHostedZone =
            let config = aws.DataAwsElasticBeanstalkHostedZone.DataAwsElasticBeanstalkHostedZoneConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsElasticBeanstalkHostedZone.DataAwsElasticBeanstalkHostedZone(StackContext.get (), logicalId, config)
