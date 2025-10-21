namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Apigatewayv2DomainNameState<'DomainName, 'DomainNameConfiguration> = { assignments: ResizeArray<aws.Apigatewayv2DomainName.Apigatewayv2DomainNameConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_domain_name">aws_apigatewayv2_domain_name</a>.
    /// </summary>
    type Apigatewayv2DomainNameBuilder(logicalId: string) =
        member _.Yield(_: unit) : Apigatewayv2DomainNameState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2DomainNameState<Missing, Missing>)

        member _.Zero(()) : Apigatewayv2DomainNameState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2DomainNameState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_domain_name#domain_name-1">Apigatewayv2DomainName#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: Apigatewayv2DomainNameState<Missing, 'DomainNameConfiguration>, value: string) : Apigatewayv2DomainNameState<Present, 'DomainNameConfiguration> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : Apigatewayv2DomainNameState<Present, 'DomainNameConfiguration>)

        /// <summary>
        /// domain_name_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_domain_name#domain_name_configuration-1">Apigatewayv2DomainName#domain_name_configuration</a>
        /// </summary>
        [<CustomOperation "domain_name_configuration">]
        member _.DomainNameConfiguration(state: Apigatewayv2DomainNameState<'DomainName, Missing>, value: aws.Apigatewayv2DomainName.Apigatewayv2DomainNameDomainNameConfiguration) : Apigatewayv2DomainNameState<'DomainName, Present> =
            state.assignments.Add(fun config -> config.DomainNameConfiguration <- value)
            ({ assignments = state.assignments } : Apigatewayv2DomainNameState<'DomainName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_domain_name#id-1">Apigatewayv2DomainName#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Apigatewayv2DomainNameState<'DomainName, 'DomainNameConfiguration>, value: string) : Apigatewayv2DomainNameState<'DomainName, 'DomainNameConfiguration> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Apigatewayv2DomainNameState<'DomainName, 'DomainNameConfiguration>

        /// <summary>
        /// mutual_tls_authentication block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_domain_name#mutual_tls_authentication-1">Apigatewayv2DomainName#mutual_tls_authentication</a>
        /// </summary>
        [<CustomOperation "mutual_tls_authentication">]
        member _.MutualTlsAuthentication(state: Apigatewayv2DomainNameState<'DomainName, 'DomainNameConfiguration>, value: aws.Apigatewayv2DomainName.Apigatewayv2DomainNameMutualTlsAuthentication) : Apigatewayv2DomainNameState<'DomainName, 'DomainNameConfiguration> =
            state.assignments.Add(fun config -> config.MutualTlsAuthentication <- value)
            state : Apigatewayv2DomainNameState<'DomainName, 'DomainNameConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_domain_name#tags-1">Apigatewayv2DomainName#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Apigatewayv2DomainNameState<'DomainName, 'DomainNameConfiguration>, value: seq<string * string>) : Apigatewayv2DomainNameState<'DomainName, 'DomainNameConfiguration> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Apigatewayv2DomainNameState<'DomainName, 'DomainNameConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_domain_name#tags_all-1">Apigatewayv2DomainName#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Apigatewayv2DomainNameState<'DomainName, 'DomainNameConfiguration>, value: seq<string * string>) : Apigatewayv2DomainNameState<'DomainName, 'DomainNameConfiguration> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Apigatewayv2DomainNameState<'DomainName, 'DomainNameConfiguration>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_domain_name#timeouts-1">Apigatewayv2DomainName#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Apigatewayv2DomainNameState<'DomainName, 'DomainNameConfiguration>, value: aws.Apigatewayv2DomainName.Apigatewayv2DomainNameTimeouts) : Apigatewayv2DomainNameState<'DomainName, 'DomainNameConfiguration> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Apigatewayv2DomainNameState<'DomainName, 'DomainNameConfiguration>

        member _.Run(state: Apigatewayv2DomainNameState<Present, Present>) : aws.Apigatewayv2DomainName.Apigatewayv2DomainName =
            let config = aws.Apigatewayv2DomainName.Apigatewayv2DomainNameConfig()
            for setter in state.assignments do
                setter config
            aws.Apigatewayv2DomainName.Apigatewayv2DomainName(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apigatewayv2DomainName: missing required arguments. Must call: domain_name, domain_name_configuration.", 9999, IsError = true)>]
        member _.Run(_: Apigatewayv2DomainNameState<_, _>) : aws.Apigatewayv2DomainName.Apigatewayv2DomainName =
            Unchecked.defaultof<aws.Apigatewayv2DomainName.Apigatewayv2DomainName>
