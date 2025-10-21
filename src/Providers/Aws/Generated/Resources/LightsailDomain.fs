namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailDomainState<'DomainName> = { assignments: ResizeArray<aws.LightsailDomain.LightsailDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_domain">aws_lightsail_domain</a>.
    /// </summary>
    type LightsailDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailDomainState<Missing> =
            ({ assignments = ResizeArray() } : LightsailDomainState<Missing>)

        member _.Zero(()) : LightsailDomainState<Missing> =
            ({ assignments = ResizeArray() } : LightsailDomainState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_domain#domain_name-1">LightsailDomain#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: LightsailDomainState<Missing>, value: string) : LightsailDomainState<Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : LightsailDomainState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_domain#id-1">LightsailDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailDomainState<'DomainName>, value: string) : LightsailDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailDomainState<'DomainName>

        member _.Run(state: LightsailDomainState<Present>) : aws.LightsailDomain.LightsailDomain =
            let config = aws.LightsailDomain.LightsailDomainConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailDomain.LightsailDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailDomain: missing required arguments. Must call: domain_name.", 9999, IsError = true)>]
        member _.Run(_: LightsailDomainState<_>) : aws.LightsailDomain.LightsailDomain =
            Unchecked.defaultof<aws.LightsailDomain.LightsailDomain>
