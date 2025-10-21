namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticsearchDomainSamlOptionsState<'DomainName> = { assignments: ResizeArray<aws.ElasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain_saml_options">aws_elasticsearch_domain_saml_options</a>.
    /// </summary>
    type ElasticsearchDomainSamlOptionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticsearchDomainSamlOptionsState<Missing> =
            ({ assignments = ResizeArray() } : ElasticsearchDomainSamlOptionsState<Missing>)

        member _.Zero(()) : ElasticsearchDomainSamlOptionsState<Missing> =
            ({ assignments = ResizeArray() } : ElasticsearchDomainSamlOptionsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain_saml_options#domain_name-1">ElasticsearchDomainSamlOptions#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: ElasticsearchDomainSamlOptionsState<Missing>, value: string) : ElasticsearchDomainSamlOptionsState<Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : ElasticsearchDomainSamlOptionsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain_saml_options#id-1">ElasticsearchDomainSamlOptions#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElasticsearchDomainSamlOptionsState<'DomainName>, value: string) : ElasticsearchDomainSamlOptionsState<'DomainName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElasticsearchDomainSamlOptionsState<'DomainName>

        /// <summary>
        /// saml_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain_saml_options#saml_options-1">ElasticsearchDomainSamlOptions#saml_options</a>
        /// </summary>
        [<CustomOperation "saml_options">]
        member _.SamlOptions(state: ElasticsearchDomainSamlOptionsState<'DomainName>, value: aws.ElasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptionsSamlOptions) : ElasticsearchDomainSamlOptionsState<'DomainName> =
            state.assignments.Add(fun config -> config.SamlOptions <- value)
            state : ElasticsearchDomainSamlOptionsState<'DomainName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain_saml_options#timeouts-1">ElasticsearchDomainSamlOptions#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ElasticsearchDomainSamlOptionsState<'DomainName>, value: aws.ElasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptionsTimeouts) : ElasticsearchDomainSamlOptionsState<'DomainName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ElasticsearchDomainSamlOptionsState<'DomainName>

        member _.Run(state: ElasticsearchDomainSamlOptionsState<Present>) : aws.ElasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptions =
            let config = aws.ElasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptionsConfig()
            for setter in state.assignments do
                setter config
            aws.ElasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptions(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elasticsearchDomainSamlOptions: missing required arguments. Must call: domain_name.", 9999, IsError = true)>]
        member _.Run(_: ElasticsearchDomainSamlOptionsState<_>) : aws.ElasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptions =
            Unchecked.defaultof<aws.ElasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptions>
