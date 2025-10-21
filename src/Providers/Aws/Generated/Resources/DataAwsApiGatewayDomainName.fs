namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsApiGatewayDomainNameState<'DomainName> = { assignments: ResizeArray<aws.DataAwsApiGatewayDomainName.DataAwsApiGatewayDomainNameConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_domain_name">aws_api_gateway_domain_name</a>.
    /// </summary>
    type DataAwsApiGatewayDomainNameBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsApiGatewayDomainNameState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsApiGatewayDomainNameState<Missing>)

        member _.Zero(()) : DataAwsApiGatewayDomainNameState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsApiGatewayDomainNameState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_domain_name#domain_name-1">DataAwsApiGatewayDomainName#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: DataAwsApiGatewayDomainNameState<Missing>, value: string) : DataAwsApiGatewayDomainNameState<Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : DataAwsApiGatewayDomainNameState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_domain_name#domain_name_id-1">DataAwsApiGatewayDomainName#domain_name_id</a>.
        /// </summary>
        [<CustomOperation "domain_name_id">]
        member _.DomainNameId(state: DataAwsApiGatewayDomainNameState<'DomainName>, value: string) : DataAwsApiGatewayDomainNameState<'DomainName> =
            state.assignments.Add(fun config -> config.DomainNameId <- value)
            state : DataAwsApiGatewayDomainNameState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_domain_name#id-1">DataAwsApiGatewayDomainName#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsApiGatewayDomainNameState<'DomainName>, value: string) : DataAwsApiGatewayDomainNameState<'DomainName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsApiGatewayDomainNameState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_domain_name#tags-1">DataAwsApiGatewayDomainName#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsApiGatewayDomainNameState<'DomainName>, value: seq<string * string>) : DataAwsApiGatewayDomainNameState<'DomainName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsApiGatewayDomainNameState<'DomainName>

        member _.Run(state: DataAwsApiGatewayDomainNameState<Present>) : aws.DataAwsApiGatewayDomainName.DataAwsApiGatewayDomainName =
            let config = aws.DataAwsApiGatewayDomainName.DataAwsApiGatewayDomainNameConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsApiGatewayDomainName.DataAwsApiGatewayDomainName(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsApiGatewayDomainName: missing required arguments. Must call: domain_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsApiGatewayDomainNameState<_>) : aws.DataAwsApiGatewayDomainName.DataAwsApiGatewayDomainName =
            Unchecked.defaultof<aws.DataAwsApiGatewayDomainName.DataAwsApiGatewayDomainName>
