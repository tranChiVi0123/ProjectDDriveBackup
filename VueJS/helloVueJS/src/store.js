import Vue from "vue";
import Vuex from "vuex";
Vue.use(Vuex);

export const store = new Vuex.Store({
  state: {
    safelyStoredNumber: 1973
  },
  getters: {
    safelyStoredNumber: state => state.safelyStoredNumber,
    storedNumberMatches(state) {
      return matchNumber => {
        return state.safelyStoredNumber === matchNumber;
      };
    }
  },
  mutations: {
    incrementStoredNumber(state) {
      state.safelyStoredNumber += 10;
    },
    decreaseStoredNumber(state, number) {
      console.log(state);
      console.log(number);
      state.safelyStoredNumber -= number;
    },
    setStoredNumber(state, newNumber) {
      state.safelyStoredNumber = newNumber;
    }
  }
});
