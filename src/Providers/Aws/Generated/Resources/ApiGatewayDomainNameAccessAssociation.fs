namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayDomainNameAccessAssociationState<'AccessAssociationSource, 'AccessAssociationSourceType, 'DomainNameArn> = { assignments: ResizeArray<aws.ApiGatewayDomainNameAccessAssociation.ApiGatewayDomainNameAccessAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name_access_association">aws_api_gateway_domain_name_access_association</a>.
    /// </summary>
    type ApiGatewayDomainNameAccessAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayDomainNameAccessAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayDomainNameAccessAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : ApiGatewayDomainNameAccessAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayDomainNameAccessAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name_access_association#access_association_source-1">ApiGatewayDomainNameAccessAssociation#access_association_source</a>.
        /// </summary>
        [<CustomOperation "access_association_source">]
        member _.AccessAssociationSource(state: ApiGatewayDomainNameAccessAssociationState<Missing, 'AccessAssociationSourceType, 'DomainNameArn>, value: string) : ApiGatewayDomainNameAccessAssociationState<Present, 'AccessAssociationSourceType, 'DomainNameArn> =
            state.assignments.Add(fun config -> config.AccessAssociationSource <- value)
            ({ assignments = state.assignments } : ApiGatewayDomainNameAccessAssociationState<Present, 'AccessAssociationSourceType, 'DomainNameArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name_access_association#access_association_source_type-1">ApiGatewayDomainNameAccessAssociation#access_association_source_type</a>.
        /// </summary>
        [<CustomOperation "access_association_source_type">]
        member _.AccessAssociationSourceType(state: ApiGatewayDomainNameAccessAssociationState<'AccessAssociationSource, Missing, 'DomainNameArn>, value: string) : ApiGatewayDomainNameAccessAssociationState<'AccessAssociationSource, Present, 'DomainNameArn> =
            state.assignments.Add(fun config -> config.AccessAssociationSourceType <- value)
            ({ assignments = state.assignments } : ApiGatewayDomainNameAccessAssociationState<'AccessAssociationSource, Present, 'DomainNameArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name_access_association#domain_name_arn-1">ApiGatewayDomainNameAccessAssociation#domain_name_arn</a>.
        /// </summary>
        [<CustomOperation "domain_name_arn">]
        member _.DomainNameArn(state: ApiGatewayDomainNameAccessAssociationState<'AccessAssociationSource, 'AccessAssociationSourceType, Missing>, value: string) : ApiGatewayDomainNameAccessAssociationState<'AccessAssociationSource, 'AccessAssociationSourceType, Present> =
            state.assignments.Add(fun config -> config.DomainNameArn <- value)
            ({ assignments = state.assignments } : ApiGatewayDomainNameAccessAssociationState<'AccessAssociationSource, 'AccessAssociationSourceType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name_access_association#tags-1">ApiGatewayDomainNameAccessAssociation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApiGatewayDomainNameAccessAssociationState<'AccessAssociationSource, 'AccessAssociationSourceType, 'DomainNameArn>, value: seq<string * string>) : ApiGatewayDomainNameAccessAssociationState<'AccessAssociationSource, 'AccessAssociationSourceType, 'DomainNameArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApiGatewayDomainNameAccessAssociationState<'AccessAssociationSource, 'AccessAssociationSourceType, 'DomainNameArn>

        member _.Run(state: ApiGatewayDomainNameAccessAssociationState<Present, Present, Present>) : aws.ApiGatewayDomainNameAccessAssociation.ApiGatewayDomainNameAccessAssociation =
            let config = aws.ApiGatewayDomainNameAccessAssociation.ApiGatewayDomainNameAccessAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayDomainNameAccessAssociation.ApiGatewayDomainNameAccessAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayDomainNameAccessAssociation: missing required arguments. Must call: access_association_source, access_association_source_type, domain_name_arn.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayDomainNameAccessAssociationState<_, _, _>) : aws.ApiGatewayDomainNameAccessAssociation.ApiGatewayDomainNameAccessAssociation =
            Unchecked.defaultof<aws.ApiGatewayDomainNameAccessAssociation.ApiGatewayDomainNameAccessAssociation>
