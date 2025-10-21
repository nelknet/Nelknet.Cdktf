namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SesDomainDkimState<'Domain> = { assignments: ResizeArray<aws.SesDomainDkim.SesDomainDkimConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_domain_dkim">aws_ses_domain_dkim</a>.
    /// </summary>
    type SesDomainDkimBuilder(logicalId: string) =
        member _.Yield(_: unit) : SesDomainDkimState<Missing> =
            ({ assignments = ResizeArray() } : SesDomainDkimState<Missing>)

        member _.Zero(()) : SesDomainDkimState<Missing> =
            ({ assignments = ResizeArray() } : SesDomainDkimState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_domain_dkim#domain-1">SesDomainDkim#domain</a>.
        /// </summary>
        [<CustomOperation "domain">]
        member _.Domain(state: SesDomainDkimState<Missing>, value: string) : SesDomainDkimState<Present> =
            state.assignments.Add(fun config -> config.Domain <- value)
            ({ assignments = state.assignments } : SesDomainDkimState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_domain_dkim#id-1">SesDomainDkim#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SesDomainDkimState<'Domain>, value: string) : SesDomainDkimState<'Domain> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SesDomainDkimState<'Domain>

        member _.Run(state: SesDomainDkimState<Present>) : aws.SesDomainDkim.SesDomainDkim =
            let config = aws.SesDomainDkim.SesDomainDkimConfig()
            for setter in state.assignments do
                setter config
            aws.SesDomainDkim.SesDomainDkim(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesDomainDkim: missing required arguments. Must call: domain.", 9999, IsError = true)>]
        member _.Run(_: SesDomainDkimState<_>) : aws.SesDomainDkim.SesDomainDkim =
            Unchecked.defaultof<aws.SesDomainDkim.SesDomainDkim>
