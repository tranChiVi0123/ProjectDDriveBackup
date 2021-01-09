import Vue from "vue";
import Vuex from "vuex";

Vue.use(Vuex);

export const store = new Vuex.Store({
  state: {
    count: 1900,
    title: "Hello Every body!"
  },
  getters: {
    getTitle: state => state.title
  },
  mutations: {
    increment(state, payload) {
      return (state.count = state.count + payload.amount);
    },
    decrement(state, payload) {
      return (state.count = state.count - payload.amount);
    },
    changeTitle(state, payload) {
      return (state.title = payload);
    }
  },
  actions: {
    increment(context, payload) {
      context.commit("increment", payload);
    },
    decrement(context, payload) {
      context.commit("decrement", payload);
    }
  }
});
