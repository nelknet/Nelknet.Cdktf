namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSesDomainIdentityState<'Domain> = { assignments: ResizeArray<aws.DataAwsSesDomainIdentity.DataAwsSesDomainIdentityConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ses_domain_identity">aws_ses_domain_identity</a>.
    /// </summary>
    type DataAwsSesDomainIdentityBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSesDomainIdentityState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSesDomainIdentityState<Missing>)

        member _.Zero(()) : DataAwsSesDomainIdentityState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSesDomainIdentityState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ses_domain_identity#domain-1">DataAwsSesDomainIdentity#domain</a>.
        /// </summary>
        [<CustomOperation "domain">]
        member _.Domain(state: DataAwsSesDomainIdentityState<Missing>, value: string) : DataAwsSesDomainIdentityState<Present> =
            state.assignments.Add(fun config -> config.Domain <- value)
            ({ assignments = state.assignments } : DataAwsSesDomainIdentityState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ses_domain_identity#id-1">DataAwsSesDomainIdentity#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSesDomainIdentityState<'Domain>, value: string) : DataAwsSesDomainIdentityState<'Domain> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSesDomainIdentityState<'Domain>

        member _.Run(state: DataAwsSesDomainIdentityState<Present>) : aws.DataAwsSesDomainIdentity.DataAwsSesDomainIdentity =
            let config = aws.DataAwsSesDomainIdentity.DataAwsSesDomainIdentityConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSesDomainIdentity.DataAwsSesDomainIdentity(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSesDomainIdentity: missing required arguments. Must call: domain.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSesDomainIdentityState<_>) : aws.DataAwsSesDomainIdentity.DataAwsSesDomainIdentity =
            Unchecked.defaultof<aws.DataAwsSesDomainIdentity.DataAwsSesDomainIdentity>
