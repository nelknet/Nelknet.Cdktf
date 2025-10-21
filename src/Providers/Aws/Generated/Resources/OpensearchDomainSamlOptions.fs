namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpensearchDomainSamlOptionsState<'DomainName> = { assignments: ResizeArray<aws.OpensearchDomainSamlOptions.OpensearchDomainSamlOptionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options">aws_opensearch_domain_saml_options</a>.
    /// </summary>
    type OpensearchDomainSamlOptionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpensearchDomainSamlOptionsState<Missing> =
            ({ assignments = ResizeArray() } : OpensearchDomainSamlOptionsState<Missing>)

        member _.Zero(()) : OpensearchDomainSamlOptionsState<Missing> =
            ({ assignments = ResizeArray() } : OpensearchDomainSamlOptionsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#domain_name-1">OpensearchDomainSamlOptions#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: OpensearchDomainSamlOptionsState<Missing>, value: string) : OpensearchDomainSamlOptionsState<Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : OpensearchDomainSamlOptionsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#id-1">OpensearchDomainSamlOptions#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpensearchDomainSamlOptionsState<'DomainName>, value: string) : OpensearchDomainSamlOptionsState<'DomainName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpensearchDomainSamlOptionsState<'DomainName>

        /// <summary>
        /// saml_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#saml_options-1">OpensearchDomainSamlOptions#saml_options</a>
        /// </summary>
        [<CustomOperation "saml_options">]
        member _.SamlOptions(state: OpensearchDomainSamlOptionsState<'DomainName>, value: aws.OpensearchDomainSamlOptions.OpensearchDomainSamlOptionsSamlOptions) : OpensearchDomainSamlOptionsState<'DomainName> =
            state.assignments.Add(fun config -> config.SamlOptions <- value)
            state : OpensearchDomainSamlOptionsState<'DomainName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#timeouts-1">OpensearchDomainSamlOptions#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: OpensearchDomainSamlOptionsState<'DomainName>, value: aws.OpensearchDomainSamlOptions.OpensearchDomainSamlOptionsTimeouts) : OpensearchDomainSamlOptionsState<'DomainName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : OpensearchDomainSamlOptionsState<'DomainName>

        member _.Run(state: OpensearchDomainSamlOptionsState<Present>) : aws.OpensearchDomainSamlOptions.OpensearchDomainSamlOptions =
            let config = aws.OpensearchDomainSamlOptions.OpensearchDomainSamlOptionsConfig()
            for setter in state.assignments do
                setter config
            aws.OpensearchDomainSamlOptions.OpensearchDomainSamlOptions(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opensearchDomainSamlOptions: missing required arguments. Must call: domain_name.", 9999, IsError = true)>]
        member _.Run(_: OpensearchDomainSamlOptionsState<_>) : aws.OpensearchDomainSamlOptions.OpensearchDomainSamlOptions =
            Unchecked.defaultof<aws.OpensearchDomainSamlOptions.OpensearchDomainSamlOptions>
