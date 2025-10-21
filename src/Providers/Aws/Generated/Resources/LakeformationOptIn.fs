namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LakeformationOptInState = { assignments: ResizeArray<aws.LakeformationOptIn.LakeformationOptInConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in">aws_lakeformation_opt_in</a>.
    /// </summary>
    type LakeformationOptInBuilder(logicalId: string) =
        member _.Yield(_: unit) : LakeformationOptInState =
            { assignments = ResizeArray() }

        member _.Zero(()) : LakeformationOptInState =
            { assignments = ResizeArray() }

        /// <summary>
        /// condition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#condition-1">LakeformationOptIn#condition</a> Accepts: aws.IResolvable | aws.LakeformationOptIn.LakeformationOptInCondition[]
        /// </summary>
        [<CustomOperation "condition">]
        member _.Condition(state: LakeformationOptInState, value: HashiCorp.Cdktf.IResolvable) : LakeformationOptInState =
            state.assignments.Add(fun config -> config.Condition <- value)
            state : LakeformationOptInState

        /// <summary>
        /// principal block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#principal-1">LakeformationOptIn#principal</a> Accepts: aws.IResolvable | aws.LakeformationOptIn.LakeformationOptInPrincipal[]
        /// </summary>
        [<CustomOperation "principal">]
        member _.Principal(state: LakeformationOptInState, value: HashiCorp.Cdktf.IResolvable) : LakeformationOptInState =
            state.assignments.Add(fun config -> config.Principal <- value)
            state : LakeformationOptInState

        /// <summary>
        /// resource_data block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#resource_data-1">LakeformationOptIn#resource_data</a> Accepts: aws.IResolvable | aws.LakeformationOptIn.LakeformationOptInResourceData[]
        /// </summary>
        [<CustomOperation "resource_data">]
        member _.ResourceData(state: LakeformationOptInState, value: HashiCorp.Cdktf.IResolvable) : LakeformationOptInState =
            state.assignments.Add(fun config -> config.ResourceData <- value)
            state : LakeformationOptInState

        member _.Run(state: LakeformationOptInState) : aws.LakeformationOptIn.LakeformationOptIn =
            let config = aws.LakeformationOptIn.LakeformationOptInConfig()
            for setter in state.assignments do
                setter config
            aws.LakeformationOptIn.LakeformationOptIn(StackContext.get (), logicalId, config)
