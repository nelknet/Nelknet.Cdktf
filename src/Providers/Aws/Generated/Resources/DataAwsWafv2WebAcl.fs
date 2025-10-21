namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsWafv2WebAclState<'Name, 'Scope> = { assignments: ResizeArray<aws.DataAwsWafv2WebAcl.DataAwsWafv2WebAclConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafv2_web_acl">aws_wafv2_web_acl</a>.
    /// </summary>
    type DataAwsWafv2WebAclBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsWafv2WebAclState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsWafv2WebAclState<Missing, Missing>)

        member _.Zero(()) : DataAwsWafv2WebAclState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsWafv2WebAclState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafv2_web_acl#name-1">DataAwsWafv2WebAcl#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsWafv2WebAclState<Missing, 'Scope>, value: string) : DataAwsWafv2WebAclState<Present, 'Scope> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsWafv2WebAclState<Present, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafv2_web_acl#scope-1">DataAwsWafv2WebAcl#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: DataAwsWafv2WebAclState<'Name, Missing>, value: string) : DataAwsWafv2WebAclState<'Name, Present> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : DataAwsWafv2WebAclState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafv2_web_acl#id-1">DataAwsWafv2WebAcl#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsWafv2WebAclState<'Name, 'Scope>, value: string) : DataAwsWafv2WebAclState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsWafv2WebAclState<'Name, 'Scope>

        member _.Run(state: DataAwsWafv2WebAclState<Present, Present>) : aws.DataAwsWafv2WebAcl.DataAwsWafv2WebAcl =
            let config = aws.DataAwsWafv2WebAcl.DataAwsWafv2WebAclConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsWafv2WebAcl.DataAwsWafv2WebAcl(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsWafv2WebAcl: missing required arguments. Must call: name, scope.", 9999, IsError = true)>]
        member _.Run(_: DataAwsWafv2WebAclState<_, _>) : aws.DataAwsWafv2WebAcl.DataAwsWafv2WebAcl =
            Unchecked.defaultof<aws.DataAwsWafv2WebAcl.DataAwsWafv2WebAcl>
