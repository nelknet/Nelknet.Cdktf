namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig> = { assignments: ResizeArray<aws.Wafv2WebAcl.Wafv2WebAclConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl">aws_wafv2_web_acl</a>.
    /// </summary>
    type Wafv2WebAclBuilder(logicalId: string) =
        member _.Yield(_: unit) : Wafv2WebAclState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Wafv2WebAclState<Missing, Missing, Missing>)

        member _.Zero(()) : Wafv2WebAclState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Wafv2WebAclState<Missing, Missing, Missing>)

        /// <summary>
        /// default_action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#default_action-1">Wafv2WebAcl#default_action</a>
        /// </summary>
        [<CustomOperation "default_action">]
        member _.DefaultAction(state: Wafv2WebAclState<Missing, 'Scope, 'VisibilityConfig>, value: aws.Wafv2WebAcl.Wafv2WebAclDefaultAction) : Wafv2WebAclState<Present, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.DefaultAction <- value)
            ({ assignments = state.assignments } : Wafv2WebAclState<Present, 'Scope, 'VisibilityConfig>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#scope-1">Wafv2WebAcl#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: Wafv2WebAclState<'DefaultAction, Missing, 'VisibilityConfig>, value: string) : Wafv2WebAclState<'DefaultAction, Present, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : Wafv2WebAclState<'DefaultAction, Present, 'VisibilityConfig>)

        /// <summary>
        /// visibility_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#visibility_config-1">Wafv2WebAcl#visibility_config</a>
        /// </summary>
        [<CustomOperation "visibility_config">]
        member _.VisibilityConfig(state: Wafv2WebAclState<'DefaultAction, 'Scope, Missing>, value: aws.Wafv2WebAcl.Wafv2WebAclVisibilityConfig) : Wafv2WebAclState<'DefaultAction, 'Scope, Present> =
            state.assignments.Add(fun config -> config.VisibilityConfig <- value)
            ({ assignments = state.assignments } : Wafv2WebAclState<'DefaultAction, 'Scope, Present>)

        /// <summary>
        /// association_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#association_config-1">Wafv2WebAcl#association_config</a>
        /// </summary>
        [<CustomOperation "association_config">]
        member _.AssociationConfig(state: Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>, value: aws.Wafv2WebAcl.Wafv2WebAclAssociationConfig) : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.AssociationConfig <- value)
            state : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>

        /// <summary>
        /// captcha_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#captcha_config-1">Wafv2WebAcl#captcha_config</a>
        /// </summary>
        [<CustomOperation "captcha_config">]
        member _.CaptchaConfig(state: Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>, value: aws.Wafv2WebAcl.Wafv2WebAclCaptchaConfig) : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.CaptchaConfig <- value)
            state : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>

        /// <summary>
        /// challenge_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#challenge_config-1">Wafv2WebAcl#challenge_config</a>
        /// </summary>
        [<CustomOperation "challenge_config">]
        member _.ChallengeConfig(state: Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>, value: aws.Wafv2WebAcl.Wafv2WebAclChallengeConfig) : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.ChallengeConfig <- value)
            state : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>

        /// <summary>
        /// custom_response_body block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#custom_response_body-1">Wafv2WebAcl#custom_response_body</a> Accepts: aws.IResolvable | aws.Wafv2WebAcl.Wafv2WebAclCustomResponseBody[]
        /// </summary>
        [<CustomOperation "custom_response_body">]
        member _.CustomResponseBody(state: Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>, value: HashiCorp.Cdktf.IResolvable) : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.CustomResponseBody <- value)
            state : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>

        /// <summary>
        /// data_protection_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#data_protection_config-1">Wafv2WebAcl#data_protection_config</a>
        /// </summary>
        [<CustomOperation "data_protection_config">]
        member _.DataProtectionConfig(state: Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>, value: aws.Wafv2WebAcl.Wafv2WebAclDataProtectionConfig) : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.DataProtectionConfig <- value)
            state : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#description-1">Wafv2WebAcl#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>, value: string) : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#id-1">Wafv2WebAcl#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>, value: string) : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#name-1">Wafv2WebAcl#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>, value: string) : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#name_prefix-1">Wafv2WebAcl#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>, value: string) : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#rule-1">Wafv2WebAcl#rule</a> Accepts: aws.IResolvable | aws.Wafv2WebAcl.Wafv2WebAclRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>, value: HashiCorp.Cdktf.IResolvable) : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.Rule <- value)
            state : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#rule_json-1">Wafv2WebAcl#rule_json</a>.
        /// </summary>
        [<CustomOperation "rule_json">]
        member _.RuleJson(state: Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>, value: string) : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.RuleJson <- value)
            state : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#tags-1">Wafv2WebAcl#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>, value: seq<string * string>) : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#tags_all-1">Wafv2WebAcl#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>, value: seq<string * string>) : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#token_domains-1">Wafv2WebAcl#token_domains</a>.
        /// </summary>
        [<CustomOperation "token_domains">]
        member _.TokenDomains(state: Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>, value: seq<string>) : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig> =
            state.assignments.Add(fun config -> config.TokenDomains <- (value |> Seq.toArray))
            state : Wafv2WebAclState<'DefaultAction, 'Scope, 'VisibilityConfig>

        member _.Run(state: Wafv2WebAclState<Present, Present, Present>) : aws.Wafv2WebAcl.Wafv2WebAcl =
            let config = aws.Wafv2WebAcl.Wafv2WebAclConfig()
            for setter in state.assignments do
                setter config
            aws.Wafv2WebAcl.Wafv2WebAcl(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafv2WebAcl: missing required arguments. Must call: default_action, scope, visibility_config.", 9999, IsError = true)>]
        member _.Run(_: Wafv2WebAclState<_, _, _>) : aws.Wafv2WebAcl.Wafv2WebAcl =
            Unchecked.defaultof<aws.Wafv2WebAcl.Wafv2WebAcl>
