namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsPrometheusDefaultScraperConfigurationState = { assignments: ResizeArray<aws.DataAwsPrometheusDefaultScraperConfiguration.DataAwsPrometheusDefaultScraperConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/prometheus_default_scraper_configuration">aws_prometheus_default_scraper_configuration</a>.
    /// </summary>
    type DataAwsPrometheusDefaultScraperConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsPrometheusDefaultScraperConfigurationState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsPrometheusDefaultScraperConfigurationState =
            { assignments = ResizeArray() }



        member _.Run(state: DataAwsPrometheusDefaultScraperConfigurationState) : aws.DataAwsPrometheusDefaultScraperConfiguration.DataAwsPrometheusDefaultScraperConfiguration =
            let config = aws.DataAwsPrometheusDefaultScraperConfiguration.DataAwsPrometheusDefaultScraperConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsPrometheusDefaultScraperConfiguration.DataAwsPrometheusDefaultScraperConfiguration(StackContext.get (), logicalId, config)
