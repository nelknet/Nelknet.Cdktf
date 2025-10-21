namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SesReceiptRuleState<'Name, 'RuleSetName> = { assignments: ResizeArray<aws.SesReceiptRule.SesReceiptRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_rule">aws_ses_receipt_rule</a>.
    /// </summary>
    type SesReceiptRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : SesReceiptRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SesReceiptRuleState<Missing, Missing>)

        member _.Zero(()) : SesReceiptRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SesReceiptRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_rule#name-1">SesReceiptRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SesReceiptRuleState<Missing, 'RuleSetName>, value: string) : SesReceiptRuleState<Present, 'RuleSetName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SesReceiptRuleState<Present, 'RuleSetName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_rule#rule_set_name-1">SesReceiptRule#rule_set_name</a>.
        /// </summary>
        [<CustomOperation "rule_set_name">]
        member _.RuleSetName(state: SesReceiptRuleState<'Name, Missing>, value: string) : SesReceiptRuleState<'Name, Present> =
            state.assignments.Add(fun config -> config.RuleSetName <- value)
            ({ assignments = state.assignments } : SesReceiptRuleState<'Name, Present>)

        /// <summary>
        /// add_header_action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_rule#add_header_action-1">SesReceiptRule#add_header_action</a> Accepts: aws.IResolvable | aws.SesReceiptRule.SesReceiptRuleAddHeaderAction[]
        /// </summary>
        [<CustomOperation "add_header_action">]
        member _.AddHeaderAction(state: SesReceiptRuleState<'Name, 'RuleSetName>, value: HashiCorp.Cdktf.IResolvable) : SesReceiptRuleState<'Name, 'RuleSetName> =
            state.assignments.Add(fun config -> config.AddHeaderAction <- value)
            state : SesReceiptRuleState<'Name, 'RuleSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_rule#after-1">SesReceiptRule#after</a>.
        /// </summary>
        [<CustomOperation "after">]
        member _.After(state: SesReceiptRuleState<'Name, 'RuleSetName>, value: string) : SesReceiptRuleState<'Name, 'RuleSetName> =
            state.assignments.Add(fun config -> config.After <- value)
            state : SesReceiptRuleState<'Name, 'RuleSetName>

        /// <summary>
        /// bounce_action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_rule#bounce_action-1">SesReceiptRule#bounce_action</a> Accepts: aws.IResolvable | aws.SesReceiptRule.SesReceiptRuleBounceAction[]
        /// </summary>
        [<CustomOperation "bounce_action">]
        member _.BounceAction(state: SesReceiptRuleState<'Name, 'RuleSetName>, value: HashiCorp.Cdktf.IResolvable) : SesReceiptRuleState<'Name, 'RuleSetName> =
            state.assignments.Add(fun config -> config.BounceAction <- value)
            state : SesReceiptRuleState<'Name, 'RuleSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_rule#enabled-1">SesReceiptRule#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SesReceiptRuleState<'Name, 'RuleSetName>, value: bool) : SesReceiptRuleState<'Name, 'RuleSetName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SesReceiptRuleState<'Name, 'RuleSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_rule#enabled-1">SesReceiptRule#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SesReceiptRuleState<'Name, 'RuleSetName>, value: HashiCorp.Cdktf.IResolvable) : SesReceiptRuleState<'Name, 'RuleSetName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SesReceiptRuleState<'Name, 'RuleSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_rule#id-1">SesReceiptRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SesReceiptRuleState<'Name, 'RuleSetName>, value: string) : SesReceiptRuleState<'Name, 'RuleSetName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SesReceiptRuleState<'Name, 'RuleSetName>

        /// <summary>
        /// lambda_action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_rule#lambda_action-1">SesReceiptRule#lambda_action</a> Accepts: aws.IResolvable | aws.SesReceiptRule.SesReceiptRuleLambdaAction[]
        /// </summary>
        [<CustomOperation "lambda_action">]
        member _.LambdaAction(state: SesReceiptRuleState<'Name, 'RuleSetName>, value: HashiCorp.Cdktf.IResolvable) : SesReceiptRuleState<'Name, 'RuleSetName> =
            state.assignments.Add(fun config -> config.LambdaAction <- value)
            state : SesReceiptRuleState<'Name, 'RuleSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_rule#recipients-1">SesReceiptRule#recipients</a>.
        /// </summary>
        [<CustomOperation "recipients">]
        member _.Recipients(state: SesReceiptRuleState<'Name, 'RuleSetName>, value: seq<string>) : SesReceiptRuleState<'Name, 'RuleSetName> =
            state.assignments.Add(fun config -> config.Recipients <- (value |> Seq.toArray))
            state : SesReceiptRuleState<'Name, 'RuleSetName>

        /// <summary>
        /// s3_action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_rule#s3_action-1">SesReceiptRule#s3_action</a> Accepts: aws.IResolvable | aws.SesReceiptRule.SesReceiptRuleS3Action[]
        /// </summary>
        [<CustomOperation "s3_action">]
        member _.S3Action(state: SesReceiptRuleState<'Name, 'RuleSetName>, value: HashiCorp.Cdktf.IResolvable) : SesReceiptRuleState<'Name, 'RuleSetName> =
            state.assignments.Add(fun config -> config.S3Action <- value)
            state : SesReceiptRuleState<'Name, 'RuleSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_rule#scan_enabled-1">SesReceiptRule#scan_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "scan_enabled">]
        member _.ScanEnabled(state: SesReceiptRuleState<'Name, 'RuleSetName>, value: bool) : SesReceiptRuleState<'Name, 'RuleSetName> =
            state.assignments.Add(fun config -> config.ScanEnabled <- value)
            state : SesReceiptRuleState<'Name, 'RuleSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_rule#scan_enabled-1">SesReceiptRule#scan_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "scan_enabled">]
        member _.ScanEnabled(state: SesReceiptRuleState<'Name, 'RuleSetName>, value: HashiCorp.Cdktf.IResolvable) : SesReceiptRuleState<'Name, 'RuleSetName> =
            state.assignments.Add(fun config -> config.ScanEnabled <- value)
            state : SesReceiptRuleState<'Name, 'RuleSetName>

        /// <summary>
        /// sns_action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_rule#sns_action-1">SesReceiptRule#sns_action</a> Accepts: aws.IResolvable | aws.SesReceiptRule.SesReceiptRuleSnsAction[]
        /// </summary>
        [<CustomOperation "sns_action">]
        member _.SnsAction(state: SesReceiptRuleState<'Name, 'RuleSetName>, value: HashiCorp.Cdktf.IResolvable) : SesReceiptRuleState<'Name, 'RuleSetName> =
            state.assignments.Add(fun config -> config.SnsAction <- value)
            state : SesReceiptRuleState<'Name, 'RuleSetName>

        /// <summary>
        /// stop_action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_rule#stop_action-1">SesReceiptRule#stop_action</a> Accepts: aws.IResolvable | aws.SesReceiptRule.SesReceiptRuleStopAction[]
        /// </summary>
        [<CustomOperation "stop_action">]
        member _.StopAction(state: SesReceiptRuleState<'Name, 'RuleSetName>, value: HashiCorp.Cdktf.IResolvable) : SesReceiptRuleState<'Name, 'RuleSetName> =
            state.assignments.Add(fun config -> config.StopAction <- value)
            state : SesReceiptRuleState<'Name, 'RuleSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_rule#tls_policy-1">SesReceiptRule#tls_policy</a>.
        /// </summary>
        [<CustomOperation "tls_policy">]
        member _.TlsPolicy(state: SesReceiptRuleState<'Name, 'RuleSetName>, value: string) : SesReceiptRuleState<'Name, 'RuleSetName> =
            state.assignments.Add(fun config -> config.TlsPolicy <- value)
            state : SesReceiptRuleState<'Name, 'RuleSetName>

        /// <summary>
        /// workmail_action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_receipt_rule#workmail_action-1">SesReceiptRule#workmail_action</a> Accepts: aws.IResolvable | aws.SesReceiptRule.SesReceiptRuleWorkmailAction[]
        /// </summary>
        [<CustomOperation "workmail_action">]
        member _.WorkmailAction(state: SesReceiptRuleState<'Name, 'RuleSetName>, value: HashiCorp.Cdktf.IResolvable) : SesReceiptRuleState<'Name, 'RuleSetName> =
            state.assignments.Add(fun config -> config.WorkmailAction <- value)
            state : SesReceiptRuleState<'Name, 'RuleSetName>

        member _.Run(state: SesReceiptRuleState<Present, Present>) : aws.SesReceiptRule.SesReceiptRule =
            let config = aws.SesReceiptRule.SesReceiptRuleConfig()
            for setter in state.assignments do
                setter config
            aws.SesReceiptRule.SesReceiptRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesReceiptRule: missing required arguments. Must call: name, rule_set_name.", 9999, IsError = true)>]
        member _.Run(_: SesReceiptRuleState<_, _>) : aws.SesReceiptRule.SesReceiptRule =
            Unchecked.defaultof<aws.SesReceiptRule.SesReceiptRule>
