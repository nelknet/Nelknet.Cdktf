namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsmAssociationState<'Name> = { assignments: ResizeArray<aws.SsmAssociation.SsmAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_association">aws_ssm_association</a>.
    /// </summary>
    type SsmAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsmAssociationState<Missing> =
            ({ assignments = ResizeArray() } : SsmAssociationState<Missing>)

        member _.Zero(()) : SsmAssociationState<Missing> =
            ({ assignments = ResizeArray() } : SsmAssociationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_association#name-1">SsmAssociation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SsmAssociationState<Missing>, value: string) : SsmAssociationState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SsmAssociationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_association#apply_only_at_cron_interval-1">SsmAssociation#apply_only_at_cron_interval</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_only_at_cron_interval">]
        member _.ApplyOnlyAtCronInterval(state: SsmAssociationState<'Name>, value: bool) : SsmAssociationState<'Name> =
            state.assignments.Add(fun config -> config.ApplyOnlyAtCronInterval <- value)
            state : SsmAssociationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_association#apply_only_at_cron_interval-1">SsmAssociation#apply_only_at_cron_interval</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_only_at_cron_interval">]
        member _.ApplyOnlyAtCronInterval(state: SsmAssociationState<'Name>, value: HashiCorp.Cdktf.IResolvable) : SsmAssociationState<'Name> =
            state.assignments.Add(fun config -> config.ApplyOnlyAtCronInterval <- value)
            state : SsmAssociationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_association#association_name-1">SsmAssociation#association_name</a>.
        /// </summary>
        [<CustomOperation "association_name">]
        member _.AssociationName(state: SsmAssociationState<'Name>, value: string) : SsmAssociationState<'Name> =
            state.assignments.Add(fun config -> config.AssociationName <- value)
            state : SsmAssociationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_association#automation_target_parameter_name-1">SsmAssociation#automation_target_parameter_name</a>.
        /// </summary>
        [<CustomOperation "automation_target_parameter_name">]
        member _.AutomationTargetParameterName(state: SsmAssociationState<'Name>, value: string) : SsmAssociationState<'Name> =
            state.assignments.Add(fun config -> config.AutomationTargetParameterName <- value)
            state : SsmAssociationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_association#compliance_severity-1">SsmAssociation#compliance_severity</a>.
        /// </summary>
        [<CustomOperation "compliance_severity">]
        member _.ComplianceSeverity(state: SsmAssociationState<'Name>, value: string) : SsmAssociationState<'Name> =
            state.assignments.Add(fun config -> config.ComplianceSeverity <- value)
            state : SsmAssociationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_association#document_version-1">SsmAssociation#document_version</a>.
        /// </summary>
        [<CustomOperation "document_version">]
        member _.DocumentVersion(state: SsmAssociationState<'Name>, value: string) : SsmAssociationState<'Name> =
            state.assignments.Add(fun config -> config.DocumentVersion <- value)
            state : SsmAssociationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_association#id-1">SsmAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsmAssociationState<'Name>, value: string) : SsmAssociationState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsmAssociationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_association#instance_id-1">SsmAssociation#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: SsmAssociationState<'Name>, value: string) : SsmAssociationState<'Name> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            state : SsmAssociationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_association#max_concurrency-1">SsmAssociation#max_concurrency</a>.
        /// </summary>
        [<CustomOperation "max_concurrency">]
        member _.MaxConcurrency(state: SsmAssociationState<'Name>, value: string) : SsmAssociationState<'Name> =
            state.assignments.Add(fun config -> config.MaxConcurrency <- value)
            state : SsmAssociationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_association#max_errors-1">SsmAssociation#max_errors</a>.
        /// </summary>
        [<CustomOperation "max_errors">]
        member _.MaxErrors(state: SsmAssociationState<'Name>, value: string) : SsmAssociationState<'Name> =
            state.assignments.Add(fun config -> config.MaxErrors <- value)
            state : SsmAssociationState<'Name>

        /// <summary>
        /// output_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_association#output_location-1">SsmAssociation#output_location</a>
        /// </summary>
        [<CustomOperation "output_location">]
        member _.OutputLocation(state: SsmAssociationState<'Name>, value: aws.SsmAssociation.SsmAssociationOutputLocation) : SsmAssociationState<'Name> =
            state.assignments.Add(fun config -> config.OutputLocation <- value)
            state : SsmAssociationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_association#parameters-1">SsmAssociation#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: SsmAssociationState<'Name>, value: seq<string * string>) : SsmAssociationState<'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : SsmAssociationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_association#schedule_expression-1">SsmAssociation#schedule_expression</a>.
        /// </summary>
        [<CustomOperation "schedule_expression">]
        member _.ScheduleExpression(state: SsmAssociationState<'Name>, value: string) : SsmAssociationState<'Name> =
            state.assignments.Add(fun config -> config.ScheduleExpression <- value)
            state : SsmAssociationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_association#sync_compliance-1">SsmAssociation#sync_compliance</a>.
        /// </summary>
        [<CustomOperation "sync_compliance">]
        member _.SyncCompliance(state: SsmAssociationState<'Name>, value: string) : SsmAssociationState<'Name> =
            state.assignments.Add(fun config -> config.SyncCompliance <- value)
            state : SsmAssociationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_association#tags-1">SsmAssociation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SsmAssociationState<'Name>, value: seq<string * string>) : SsmAssociationState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SsmAssociationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_association#tags_all-1">SsmAssociation#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SsmAssociationState<'Name>, value: seq<string * string>) : SsmAssociationState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SsmAssociationState<'Name>

        /// <summary>
        /// targets block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_association#targets-1">SsmAssociation#targets</a> Accepts: aws.IResolvable | aws.SsmAssociation.SsmAssociationTargets[]
        /// </summary>
        [<CustomOperation "targets">]
        member _.Targets(state: SsmAssociationState<'Name>, value: HashiCorp.Cdktf.IResolvable) : SsmAssociationState<'Name> =
            state.assignments.Add(fun config -> config.Targets <- value)
            state : SsmAssociationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_association#wait_for_success_timeout_seconds-1">SsmAssociation#wait_for_success_timeout_seconds</a>.
        /// </summary>
        [<CustomOperation "wait_for_success_timeout_seconds">]
        member _.WaitForSuccessTimeoutSeconds(state: SsmAssociationState<'Name>, value: double) : SsmAssociationState<'Name> =
            state.assignments.Add(fun config -> config.WaitForSuccessTimeoutSeconds <- value)
            state : SsmAssociationState<'Name>

        member _.Run(state: SsmAssociationState<Present>) : aws.SsmAssociation.SsmAssociation =
            let config = aws.SsmAssociation.SsmAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.SsmAssociation.SsmAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssmAssociation: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: SsmAssociationState<_>) : aws.SsmAssociation.SsmAssociation =
            Unchecked.defaultof<aws.SsmAssociation.SsmAssociation>
