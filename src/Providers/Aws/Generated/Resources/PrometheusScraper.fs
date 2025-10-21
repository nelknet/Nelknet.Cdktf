namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrometheusScraperState<'ScrapeConfiguration> = { assignments: ResizeArray<aws.PrometheusScraper.PrometheusScraperConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper">aws_prometheus_scraper</a>.
    /// </summary>
    type PrometheusScraperBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrometheusScraperState<Missing> =
            ({ assignments = ResizeArray() } : PrometheusScraperState<Missing>)

        member _.Zero(()) : PrometheusScraperState<Missing> =
            ({ assignments = ResizeArray() } : PrometheusScraperState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#scrape_configuration-1">PrometheusScraper#scrape_configuration</a>.
        /// </summary>
        [<CustomOperation "scrape_configuration">]
        member _.ScrapeConfiguration(state: PrometheusScraperState<Missing>, value: string) : PrometheusScraperState<Present> =
            state.assignments.Add(fun config -> config.ScrapeConfiguration <- value)
            ({ assignments = state.assignments } : PrometheusScraperState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#alias-1">PrometheusScraper#alias</a>.
        /// </summary>
        [<CustomOperation "alias">]
        member _.Alias(state: PrometheusScraperState<'ScrapeConfiguration>, value: string) : PrometheusScraperState<'ScrapeConfiguration> =
            state.assignments.Add(fun config -> config.Alias <- value)
            state : PrometheusScraperState<'ScrapeConfiguration>

        /// <summary>
        /// destination block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#destination-1">PrometheusScraper#destination</a> Accepts: aws.IResolvable | aws.PrometheusScraper.PrometheusScraperDestination[]
        /// </summary>
        [<CustomOperation "destination">]
        member _.Destination(state: PrometheusScraperState<'ScrapeConfiguration>, value: HashiCorp.Cdktf.IResolvable) : PrometheusScraperState<'ScrapeConfiguration> =
            state.assignments.Add(fun config -> config.Destination <- value)
            state : PrometheusScraperState<'ScrapeConfiguration>

        /// <summary>
        /// role_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#role_configuration-1">PrometheusScraper#role_configuration</a> Accepts: aws.IResolvable | aws.PrometheusScraper.PrometheusScraperRoleConfiguration[]
        /// </summary>
        [<CustomOperation "role_configuration">]
        member _.RoleConfiguration(state: PrometheusScraperState<'ScrapeConfiguration>, value: HashiCorp.Cdktf.IResolvable) : PrometheusScraperState<'ScrapeConfiguration> =
            state.assignments.Add(fun config -> config.RoleConfiguration <- value)
            state : PrometheusScraperState<'ScrapeConfiguration>

        /// <summary>
        /// source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#source-1">PrometheusScraper#source</a> Accepts: aws.IResolvable | aws.PrometheusScraper.PrometheusScraperSource[]
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: PrometheusScraperState<'ScrapeConfiguration>, value: HashiCorp.Cdktf.IResolvable) : PrometheusScraperState<'ScrapeConfiguration> =
            state.assignments.Add(fun config -> config.Source <- value)
            state : PrometheusScraperState<'ScrapeConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#tags-1">PrometheusScraper#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PrometheusScraperState<'ScrapeConfiguration>, value: seq<string * string>) : PrometheusScraperState<'ScrapeConfiguration> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PrometheusScraperState<'ScrapeConfiguration>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#timeouts-1">PrometheusScraper#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PrometheusScraperState<'ScrapeConfiguration>, value: aws.PrometheusScraper.PrometheusScraperTimeouts) : PrometheusScraperState<'ScrapeConfiguration> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PrometheusScraperState<'ScrapeConfiguration>

        member _.Run(state: PrometheusScraperState<Present>) : aws.PrometheusScraper.PrometheusScraper =
            let config = aws.PrometheusScraper.PrometheusScraperConfig()
            for setter in state.assignments do
                setter config
            aws.PrometheusScraper.PrometheusScraper(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.prometheusScraper: missing required arguments. Must call: scrape_configuration.", 9999, IsError = true)>]
        member _.Run(_: PrometheusScraperState<_>) : aws.PrometheusScraper.PrometheusScraper =
            Unchecked.defaultof<aws.PrometheusScraper.PrometheusScraper>
