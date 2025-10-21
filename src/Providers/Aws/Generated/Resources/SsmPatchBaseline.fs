namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsmPatchBaselineState<'Name> = { assignments: ResizeArray<aws.SsmPatchBaseline.SsmPatchBaselineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline">aws_ssm_patch_baseline</a>.
    /// </summary>
    type SsmPatchBaselineBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsmPatchBaselineState<Missing> =
            ({ assignments = ResizeArray() } : SsmPatchBaselineState<Missing>)

        member _.Zero(()) : SsmPatchBaselineState<Missing> =
            ({ assignments = ResizeArray() } : SsmPatchBaselineState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#name-1">SsmPatchBaseline#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SsmPatchBaselineState<Missing>, value: string) : SsmPatchBaselineState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SsmPatchBaselineState<Present>)

        /// <summary>
        /// approval_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#approval_rule-1">SsmPatchBaseline#approval_rule</a> Accepts: aws.IResolvable | aws.SsmPatchBaseline.SsmPatchBaselineApprovalRule[]
        /// </summary>
        [<CustomOperation "approval_rule">]
        member _.ApprovalRule(state: SsmPatchBaselineState<'Name>, value: HashiCorp.Cdktf.IResolvable) : SsmPatchBaselineState<'Name> =
            state.assignments.Add(fun config -> config.ApprovalRule <- value)
            state : SsmPatchBaselineState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#approved_patches-1">SsmPatchBaseline#approved_patches</a>.
        /// </summary>
        [<CustomOperation "approved_patches">]
        member _.ApprovedPatches(state: SsmPatchBaselineState<'Name>, value: seq<string>) : SsmPatchBaselineState<'Name> =
            state.assignments.Add(fun config -> config.ApprovedPatches <- (value |> Seq.toArray))
            state : SsmPatchBaselineState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#approved_patches_compliance_level-1">SsmPatchBaseline#approved_patches_compliance_level</a>.
        /// </summary>
        [<CustomOperation "approved_patches_compliance_level">]
        member _.ApprovedPatchesComplianceLevel(state: SsmPatchBaselineState<'Name>, value: string) : SsmPatchBaselineState<'Name> =
            state.assignments.Add(fun config -> config.ApprovedPatchesComplianceLevel <- value)
            state : SsmPatchBaselineState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#approved_patches_enable_non_security-1">SsmPatchBaseline#approved_patches_enable_non_security</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "approved_patches_enable_non_security">]
        member _.ApprovedPatchesEnableNonSecurity(state: SsmPatchBaselineState<'Name>, value: bool) : SsmPatchBaselineState<'Name> =
            state.assignments.Add(fun config -> config.ApprovedPatchesEnableNonSecurity <- value)
            state : SsmPatchBaselineState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#approved_patches_enable_non_security-1">SsmPatchBaseline#approved_patches_enable_non_security</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "approved_patches_enable_non_security">]
        member _.ApprovedPatchesEnableNonSecurity(state: SsmPatchBaselineState<'Name>, value: HashiCorp.Cdktf.IResolvable) : SsmPatchBaselineState<'Name> =
            state.assignments.Add(fun config -> config.ApprovedPatchesEnableNonSecurity <- value)
            state : SsmPatchBaselineState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#description-1">SsmPatchBaseline#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SsmPatchBaselineState<'Name>, value: string) : SsmPatchBaselineState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SsmPatchBaselineState<'Name>

        /// <summary>
        /// global_filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#global_filter-1">SsmPatchBaseline#global_filter</a> Accepts: aws.IResolvable | aws.SsmPatchBaseline.SsmPatchBaselineGlobalFilter[]
        /// </summary>
        [<CustomOperation "global_filter">]
        member _.GlobalFilter(state: SsmPatchBaselineState<'Name>, value: HashiCorp.Cdktf.IResolvable) : SsmPatchBaselineState<'Name> =
            state.assignments.Add(fun config -> config.GlobalFilter <- value)
            state : SsmPatchBaselineState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#id-1">SsmPatchBaseline#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsmPatchBaselineState<'Name>, value: string) : SsmPatchBaselineState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsmPatchBaselineState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#operating_system-1">SsmPatchBaseline#operating_system</a>.
        /// </summary>
        [<CustomOperation "operating_system">]
        member _.OperatingSystem(state: SsmPatchBaselineState<'Name>, value: string) : SsmPatchBaselineState<'Name> =
            state.assignments.Add(fun config -> config.OperatingSystem <- value)
            state : SsmPatchBaselineState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#rejected_patches-1">SsmPatchBaseline#rejected_patches</a>.
        /// </summary>
        [<CustomOperation "rejected_patches">]
        member _.RejectedPatches(state: SsmPatchBaselineState<'Name>, value: seq<string>) : SsmPatchBaselineState<'Name> =
            state.assignments.Add(fun config -> config.RejectedPatches <- (value |> Seq.toArray))
            state : SsmPatchBaselineState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#rejected_patches_action-1">SsmPatchBaseline#rejected_patches_action</a>.
        /// </summary>
        [<CustomOperation "rejected_patches_action">]
        member _.RejectedPatchesAction(state: SsmPatchBaselineState<'Name>, value: string) : SsmPatchBaselineState<'Name> =
            state.assignments.Add(fun config -> config.RejectedPatchesAction <- value)
            state : SsmPatchBaselineState<'Name>

        /// <summary>
        /// source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#source-1">SsmPatchBaseline#source</a> Accepts: aws.IResolvable | aws.SsmPatchBaseline.SsmPatchBaselineSource[]
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: SsmPatchBaselineState<'Name>, value: HashiCorp.Cdktf.IResolvable) : SsmPatchBaselineState<'Name> =
            state.assignments.Add(fun config -> config.Source <- value)
            state : SsmPatchBaselineState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#tags-1">SsmPatchBaseline#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SsmPatchBaselineState<'Name>, value: seq<string * string>) : SsmPatchBaselineState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SsmPatchBaselineState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#tags_all-1">SsmPatchBaseline#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SsmPatchBaselineState<'Name>, value: seq<string * string>) : SsmPatchBaselineState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SsmPatchBaselineState<'Name>

        member _.Run(state: SsmPatchBaselineState<Present>) : aws.SsmPatchBaseline.SsmPatchBaseline =
            let config = aws.SsmPatchBaseline.SsmPatchBaselineConfig()
            for setter in state.assignments do
                setter config
            aws.SsmPatchBaseline.SsmPatchBaseline(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssmPatchBaseline: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: SsmPatchBaselineState<_>) : aws.SsmPatchBaseline.SsmPatchBaseline =
            Unchecked.defaultof<aws.SsmPatchBaseline.SsmPatchBaseline>
