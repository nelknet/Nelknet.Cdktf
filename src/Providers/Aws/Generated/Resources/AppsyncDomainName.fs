namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppsyncDomainNameState<'CertificateArn, 'DomainName> = { assignments: ResizeArray<aws.AppsyncDomainName.AppsyncDomainNameConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_domain_name">aws_appsync_domain_name</a>.
    /// </summary>
    type AppsyncDomainNameBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppsyncDomainNameState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppsyncDomainNameState<Missing, Missing>)

        member _.Zero(()) : AppsyncDomainNameState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppsyncDomainNameState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_domain_name#certificate_arn-1">AppsyncDomainName#certificate_arn</a>.
        /// </summary>
        [<CustomOperation "certificate_arn">]
        member _.CertificateArn(state: AppsyncDomainNameState<Missing, 'DomainName>, value: string) : AppsyncDomainNameState<Present, 'DomainName> =
            state.assignments.Add(fun config -> config.CertificateArn <- value)
            ({ assignments = state.assignments } : AppsyncDomainNameState<Present, 'DomainName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_domain_name#domain_name-1">AppsyncDomainName#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: AppsyncDomainNameState<'CertificateArn, Missing>, value: string) : AppsyncDomainNameState<'CertificateArn, Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : AppsyncDomainNameState<'CertificateArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_domain_name#description-1">AppsyncDomainName#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AppsyncDomainNameState<'CertificateArn, 'DomainName>, value: string) : AppsyncDomainNameState<'CertificateArn, 'DomainName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AppsyncDomainNameState<'CertificateArn, 'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_domain_name#id-1">AppsyncDomainName#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppsyncDomainNameState<'CertificateArn, 'DomainName>, value: string) : AppsyncDomainNameState<'CertificateArn, 'DomainName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppsyncDomainNameState<'CertificateArn, 'DomainName>

        member _.Run(state: AppsyncDomainNameState<Present, Present>) : aws.AppsyncDomainName.AppsyncDomainName_ =
            let config = aws.AppsyncDomainName.AppsyncDomainNameConfig()
            for setter in state.assignments do
                setter config
            aws.AppsyncDomainName.AppsyncDomainName_(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appsyncDomainName: missing required arguments. Must call: certificate_arn, domain_name.", 9999, IsError = true)>]
        member _.Run(_: AppsyncDomainNameState<_, _>) : aws.AppsyncDomainName.AppsyncDomainName_ =
            Unchecked.defaultof<aws.AppsyncDomainName.AppsyncDomainName_>
