namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutoscalingplansScalingPlanState<'ApplicationSource, 'Name, 'ScalingInstruction> = { assignments: ResizeArray<aws.AutoscalingplansScalingPlan.AutoscalingplansScalingPlanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscalingplans_scaling_plan">aws_autoscalingplans_scaling_plan</a>.
    /// </summary>
    type AutoscalingplansScalingPlanBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutoscalingplansScalingPlanState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutoscalingplansScalingPlanState<Missing, Missing, Missing>)

        member _.Zero(()) : AutoscalingplansScalingPlanState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutoscalingplansScalingPlanState<Missing, Missing, Missing>)

        /// <summary>
        /// application_source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscalingplans_scaling_plan#application_source-1">AutoscalingplansScalingPlan#application_source</a>
        /// </summary>
        [<CustomOperation "application_source">]
        member _.ApplicationSource(state: AutoscalingplansScalingPlanState<Missing, 'Name, 'ScalingInstruction>, value: aws.AutoscalingplansScalingPlan.AutoscalingplansScalingPlanApplicationSource) : AutoscalingplansScalingPlanState<Present, 'Name, 'ScalingInstruction> =
            state.assignments.Add(fun config -> config.ApplicationSource <- value)
            ({ assignments = state.assignments } : AutoscalingplansScalingPlanState<Present, 'Name, 'ScalingInstruction>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscalingplans_scaling_plan#name-1">AutoscalingplansScalingPlan#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutoscalingplansScalingPlanState<'ApplicationSource, Missing, 'ScalingInstruction>, value: string) : AutoscalingplansScalingPlanState<'ApplicationSource, Present, 'ScalingInstruction> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutoscalingplansScalingPlanState<'ApplicationSource, Present, 'ScalingInstruction>)

        /// <summary>
        /// scaling_instruction block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscalingplans_scaling_plan#scaling_instruction-1">AutoscalingplansScalingPlan#scaling_instruction</a> Accepts: aws.IResolvable | aws.AutoscalingplansScalingPlan.AutoscalingplansScalingPlanScalingInstruction[]
        /// </summary>
        [<CustomOperation "scaling_instruction">]
        member _.ScalingInstruction(state: AutoscalingplansScalingPlanState<'ApplicationSource, 'Name, Missing>, value: HashiCorp.Cdktf.IResolvable) : AutoscalingplansScalingPlanState<'ApplicationSource, 'Name, Present> =
            state.assignments.Add(fun config -> config.ScalingInstruction <- value)
            ({ assignments = state.assignments } : AutoscalingplansScalingPlanState<'ApplicationSource, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscalingplans_scaling_plan#id-1">AutoscalingplansScalingPlan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutoscalingplansScalingPlanState<'ApplicationSource, 'Name, 'ScalingInstruction>, value: string) : AutoscalingplansScalingPlanState<'ApplicationSource, 'Name, 'ScalingInstruction> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutoscalingplansScalingPlanState<'ApplicationSource, 'Name, 'ScalingInstruction>

        member _.Run(state: AutoscalingplansScalingPlanState<Present, Present, Present>) : aws.AutoscalingplansScalingPlan.AutoscalingplansScalingPlan =
            let config = aws.AutoscalingplansScalingPlan.AutoscalingplansScalingPlanConfig()
            for setter in state.assignments do
                setter config
            aws.AutoscalingplansScalingPlan.AutoscalingplansScalingPlan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.autoscalingplansScalingPlan: missing required arguments. Must call: application_source, name, scaling_instruction.", 9999, IsError = true)>]
        member _.Run(_: AutoscalingplansScalingPlanState<_, _, _>) : aws.AutoscalingplansScalingPlan.AutoscalingplansScalingPlan =
            Unchecked.defaultof<aws.AutoscalingplansScalingPlan.AutoscalingplansScalingPlan>
