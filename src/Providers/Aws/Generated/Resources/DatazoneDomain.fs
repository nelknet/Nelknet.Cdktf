namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatazoneDomainState<'DomainExecutionRole, 'Name> = { assignments: ResizeArray<aws.DatazoneDomain.DatazoneDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_domain">aws_datazone_domain</a>.
    /// </summary>
    type DatazoneDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatazoneDomainState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatazoneDomainState<Missing, Missing>)

        member _.Zero(()) : DatazoneDomainState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatazoneDomainState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_domain#domain_execution_role-1">DatazoneDomain#domain_execution_role</a>.
        /// </summary>
        [<CustomOperation "domain_execution_role">]
        member _.DomainExecutionRole(state: DatazoneDomainState<Missing, 'Name>, value: string) : DatazoneDomainState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DomainExecutionRole <- value)
            ({ assignments = state.assignments } : DatazoneDomainState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_domain#name-1">DatazoneDomain#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DatazoneDomainState<'DomainExecutionRole, Missing>, value: string) : DatazoneDomainState<'DomainExecutionRole, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DatazoneDomainState<'DomainExecutionRole, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_domain#description-1">DatazoneDomain#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DatazoneDomainState<'DomainExecutionRole, 'Name>, value: string) : DatazoneDomainState<'DomainExecutionRole, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DatazoneDomainState<'DomainExecutionRole, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_domain#kms_key_identifier-1">DatazoneDomain#kms_key_identifier</a>.
        /// </summary>
        [<CustomOperation "kms_key_identifier">]
        member _.KmsKeyIdentifier(state: DatazoneDomainState<'DomainExecutionRole, 'Name>, value: string) : DatazoneDomainState<'DomainExecutionRole, 'Name> =
            state.assignments.Add(fun config -> config.KmsKeyIdentifier <- value)
            state : DatazoneDomainState<'DomainExecutionRole, 'Name>

        /// <summary>
        /// single_sign_on block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_domain#single_sign_on-1">DatazoneDomain#single_sign_on</a> Accepts: aws.IResolvable | aws.DatazoneDomain.DatazoneDomainSingleSignOn[]
        /// </summary>
        [<CustomOperation "single_sign_on">]
        member _.SingleSignOn(state: DatazoneDomainState<'DomainExecutionRole, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DatazoneDomainState<'DomainExecutionRole, 'Name> =
            state.assignments.Add(fun config -> config.SingleSignOn <- value)
            state : DatazoneDomainState<'DomainExecutionRole, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_domain#skip_deletion_check-1">DatazoneDomain#skip_deletion_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_deletion_check">]
        member _.SkipDeletionCheck(state: DatazoneDomainState<'DomainExecutionRole, 'Name>, value: bool) : DatazoneDomainState<'DomainExecutionRole, 'Name> =
            state.assignments.Add(fun config -> config.SkipDeletionCheck <- value)
            state : DatazoneDomainState<'DomainExecutionRole, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_domain#skip_deletion_check-1">DatazoneDomain#skip_deletion_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_deletion_check">]
        member _.SkipDeletionCheck(state: DatazoneDomainState<'DomainExecutionRole, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DatazoneDomainState<'DomainExecutionRole, 'Name> =
            state.assignments.Add(fun config -> config.SkipDeletionCheck <- value)
            state : DatazoneDomainState<'DomainExecutionRole, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_domain#tags-1">DatazoneDomain#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DatazoneDomainState<'DomainExecutionRole, 'Name>, value: seq<string * string>) : DatazoneDomainState<'DomainExecutionRole, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DatazoneDomainState<'DomainExecutionRole, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_domain#timeouts-1">DatazoneDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DatazoneDomainState<'DomainExecutionRole, 'Name>, value: aws.DatazoneDomain.DatazoneDomainTimeouts) : DatazoneDomainState<'DomainExecutionRole, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DatazoneDomainState<'DomainExecutionRole, 'Name>

        member _.Run(state: DatazoneDomainState<Present, Present>) : aws.DatazoneDomain.DatazoneDomain =
            let config = aws.DatazoneDomain.DatazoneDomainConfig()
            for setter in state.assignments do
                setter config
            aws.DatazoneDomain.DatazoneDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datazoneDomain: missing required arguments. Must call: domain_execution_role, name.", 9999, IsError = true)>]
        member _.Run(_: DatazoneDomainState<_, _>) : aws.DatazoneDomain.DatazoneDomain =
            Unchecked.defaultof<aws.DatazoneDomain.DatazoneDomain>
