import { UserModel } from '../user/user.model';
import { ErrorModel } from '../error/error.model';

export class BudgetModel {
  id: number;
  datetime: Date;
  customer: UserModel;
  fullstackamount: number;
  designeramount: number;
  scrummasteramount: number;
  projectowneramount: number;
  durationdays: number;
  value: number;
  error: ErrorModel;
}
