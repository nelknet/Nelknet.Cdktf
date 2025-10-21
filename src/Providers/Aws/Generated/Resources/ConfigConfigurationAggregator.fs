namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConfigConfigurationAggregatorState<'Name> = { assignments: ResizeArray<aws.ConfigConfigurationAggregator.ConfigConfigurationAggregatorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_aggregator">aws_config_configuration_aggregator</a>.
    /// </summary>
    type ConfigConfigurationAggregatorBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConfigConfigurationAggregatorState<Missing> =
            ({ assignments = ResizeArray() } : ConfigConfigurationAggregatorState<Missing>)

        member _.Zero(()) : ConfigConfigurationAggregatorState<Missing> =
            ({ assignments = ResizeArray() } : ConfigConfigurationAggregatorState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_aggregator#name-1">ConfigConfigurationAggregator#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConfigConfigurationAggregatorState<Missing>, value: string) : ConfigConfigurationAggregatorState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ConfigConfigurationAggregatorState<Present>)

        /// <summary>
        /// account_aggregation_source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_aggregator#account_aggregation_source-1">ConfigConfigurationAggregator#account_aggregation_source</a>
        /// </summary>
        [<CustomOperation "account_aggregation_source">]
        member _.AccountAggregationSource(state: ConfigConfigurationAggregatorState<'Name>, value: aws.ConfigConfigurationAggregator.ConfigConfigurationAggregatorAccountAggregationSource) : ConfigConfigurationAggregatorState<'Name> =
            state.assignments.Add(fun config -> config.AccountAggregationSource <- value)
            state : ConfigConfigurationAggregatorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_aggregator#id-1">ConfigConfigurationAggregator#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConfigConfigurationAggregatorState<'Name>, value: string) : ConfigConfigurationAggregatorState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConfigConfigurationAggregatorState<'Name>

        /// <summary>
        /// organization_aggregation_source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_aggregator#organization_aggregation_source-1">ConfigConfigurationAggregator#organization_aggregation_source</a>
        /// </summary>
        [<CustomOperation "organization_aggregation_source">]
        member _.OrganizationAggregationSource(state: ConfigConfigurationAggregatorState<'Name>, value: aws.ConfigConfigurationAggregator.ConfigConfigurationAggregatorOrganizationAggregationSource) : ConfigConfigurationAggregatorState<'Name> =
            state.assignments.Add(fun config -> config.OrganizationAggregationSource <- value)
            state : ConfigConfigurationAggregatorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_aggregator#tags-1">ConfigConfigurationAggregator#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ConfigConfigurationAggregatorState<'Name>, value: seq<string * string>) : ConfigConfigurationAggregatorState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ConfigConfigurationAggregatorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_aggregator#tags_all-1">ConfigConfigurationAggregator#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ConfigConfigurationAggregatorState<'Name>, value: seq<string * string>) : ConfigConfigurationAggregatorState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ConfigConfigurationAggregatorState<'Name>

        member _.Run(state: ConfigConfigurationAggregatorState<Present>) : aws.ConfigConfigurationAggregator.ConfigConfigurationAggregator =
            let config = aws.ConfigConfigurationAggregator.ConfigConfigurationAggregatorConfig()
            for setter in state.assignments do
                setter config
            aws.ConfigConfigurationAggregator.ConfigConfigurationAggregator(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.configConfigurationAggregator: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: ConfigConfigurationAggregatorState<_>) : aws.ConfigConfigurationAggregator.ConfigConfigurationAggregator =
            Unchecked.defaultof<aws.ConfigConfigurationAggregator.ConfigConfigurationAggregator>
