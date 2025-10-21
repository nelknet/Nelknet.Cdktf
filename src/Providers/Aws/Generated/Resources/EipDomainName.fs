namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EipDomainNameState<'AllocationId, 'DomainName> = { assignments: ResizeArray<aws.EipDomainName.EipDomainNameConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip_domain_name">aws_eip_domain_name</a>.
    /// </summary>
    type EipDomainNameBuilder(logicalId: string) =
        member _.Yield(_: unit) : EipDomainNameState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EipDomainNameState<Missing, Missing>)

        member _.Zero(()) : EipDomainNameState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EipDomainNameState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip_domain_name#allocation_id-1">EipDomainName#allocation_id</a>.
        /// </summary>
        [<CustomOperation "allocation_id">]
        member _.AllocationId(state: EipDomainNameState<Missing, 'DomainName>, value: string) : EipDomainNameState<Present, 'DomainName> =
            state.assignments.Add(fun config -> config.AllocationId <- value)
            ({ assignments = state.assignments } : EipDomainNameState<Present, 'DomainName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip_domain_name#domain_name-1">EipDomainName#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: EipDomainNameState<'AllocationId, Missing>, value: string) : EipDomainNameState<'AllocationId, Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : EipDomainNameState<'AllocationId, Present>)

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip_domain_name#timeouts-1">EipDomainName#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EipDomainNameState<'AllocationId, 'DomainName>, value: aws.EipDomainName.EipDomainNameTimeouts) : EipDomainNameState<'AllocationId, 'DomainName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EipDomainNameState<'AllocationId, 'DomainName>

        member _.Run(state: EipDomainNameState<Present, Present>) : aws.EipDomainName.EipDomainName =
            let config = aws.EipDomainName.EipDomainNameConfig()
            for setter in state.assignments do
                setter config
            aws.EipDomainName.EipDomainName(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.eipDomainName: missing required arguments. Must call: allocation_id, domain_name.", 9999, IsError = true)>]
        member _.Run(_: EipDomainNameState<_, _>) : aws.EipDomainName.EipDomainName =
            Unchecked.defaultof<aws.EipDomainName.EipDomainName>
